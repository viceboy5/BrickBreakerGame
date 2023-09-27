using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class BrickBehaviour : MonoBehaviour
{
    public int health;
    public UnityEvent zeroHealth, startEvent;
    private MeshRenderer renderer;
    private MatData currentMat;
    public MatDataList matList;

    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    public void UpdateHealth(int num)
    {
        health += num;
    }

    public void SetInitialHealthRandomly()
    {
        int healthRange = matList.MatList.Count;
        health = Random.Range(1, healthRange);
        currentMat = matList.MatList[health -1];
        renderer.material = currentMat.mat;
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
