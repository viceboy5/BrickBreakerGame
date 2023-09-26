using System;
using UnityEngine;
using UnityEngine.Events;

public class BrickBehaviour : MonoBehaviour
{
    public int health;
    public UnityEvent zeroHealth;
    private MeshRenderer renderer;

    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
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
    
    
    public void ColorChange(Material newMat)
    {
        renderer.material = newMat;
    }
}
