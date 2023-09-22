using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMovementBehaviour : MonoBehaviour
{
    private Rigidbody rigidbody;
    public FloatData speed;
    
    
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        Debug.Log(rigidbody);
    }
    
    public void SetVelocity()
    {
        rigidbody.AddForce(Vector3.forward * Time.deltaTime * speed.value);
    }
}
