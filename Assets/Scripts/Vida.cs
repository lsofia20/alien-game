using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float vida;

    void Start()
    {
        
    }


    void Update()
    {
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
