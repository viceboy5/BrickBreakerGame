using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMovementBehaviour : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed;
    
    
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    
    public void SetVelocity()
    {
        rigidbody.AddForce(Vector3.forward * Time.deltaTime * speed *100);
    }
}
