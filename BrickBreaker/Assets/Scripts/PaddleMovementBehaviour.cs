using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PaddleMovementBehaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraObj.transform.position.y));
        offset.z = 0f;
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraObj.transform.position.y)) + offset;
            position.z = transform.position.z;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
    }
}
