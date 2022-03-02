using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlDisparo : MonoBehaviour
{
    [SerializeField] int vidas;
    [SerializeField] Slider sliderVidas;

    void Start()
    {
        
    }


    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Disparo"))
        {
            vidas--;
            sliderVidas.value = vidas;
            if (vidas <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
