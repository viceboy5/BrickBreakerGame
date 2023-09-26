using System;
using UnityEngine;
using UnityEngine.Events;

public class BrickBehaviour : MonoBehaviour
{
    public int health;
    public UnityEvent zeroHealth, startEvent;
    private MeshRenderer renderer;

    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    public void UpdateHealth(int number)
    {
        health += number;
    }

    public void CheckForZero()
    {
        if (health==0)
        {
            zeroHealth.Invoke();
        }
    }
    
    
    public void ColorChange(MatDataList matList)
    {
        renderer.material = matList.currentMat.mat;
    }
}
