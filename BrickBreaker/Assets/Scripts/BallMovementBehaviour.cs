using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
public class BallMovementBehaviour : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed, bounceVariety;
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
    
    public void OnCollisionEnter(Collision collision)
    {
        Vector3 randomDirection = new Vector3(0f, 0f, Random.Range(-bounceVariety, bounceVariety)).normalized;
        rigidbody.AddForce(randomDirection.normalized, ForceMode.VelocityChange);
    }
}
