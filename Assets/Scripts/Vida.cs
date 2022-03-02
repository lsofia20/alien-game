using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float vidas;

    void Start()
    {
        
    }


    void Update()
    {
        if (vidas <= 0)
        {
            Destroy(gameObject);
        }
    }
}
