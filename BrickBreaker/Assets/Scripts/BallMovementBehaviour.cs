using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
public class BallMovementBehaviour : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed;
    private Vector3 force = Vector3.zero;
    
    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Invoke(nameof(SetVelocityRandomX), 1f);
    }

    public void SetVelocityRandomX()
    {
        force.x = Random.Range(-1f, 1f);
        force.y = 0f;
        force.z = -1f;
        rigidbody.AddForce(force.normalized * Time.deltaTime * speed * 100);
    }
}
