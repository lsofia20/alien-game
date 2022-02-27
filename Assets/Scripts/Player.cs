using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject bullet;
    float minX, maxX, minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 esqInfIzq = (Camera.main).ViewportToWorldPoint(new Vector2(0,0));
        Vector2 esqSupDer = (Camera.main).ViewportToWorldPoint(new Vector2(1,1));

        minX = esqInfIzq.x;
        maxX = esqSupDer.x;
        minY = esqInfIzq.y;
        maxY = esqSupDer.y;

    }

    // Update is called once per frame
    void Update()
    {
        // velocidad - mov
        float dirH = Input.GetAxis("Horizontal");
        float dirV = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(dirH * speed * Time.deltaTime,
            dirV * speed * Time.deltaTime));

        //Verificar posici�n
        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, minX, maxX),
            Mathf.Clamp(transform.position.y, minY, maxY)
            );

        //Disparar bala
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
