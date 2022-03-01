using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    Rigidbody2D myBody;
    [SerializeField] float speed;
    int lifePoints=10;
    float minX, maxX, minY, maxY;
    Animal animal;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();

        Vector2 esqInfIzq = (Camera.main).ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 esqSupDer = (Camera.main).ViewportToWorldPoint(new Vector2(1, 1));

        minX = esqInfIzq.x;
        maxX = esqSupDer.x;
        minY = esqInfIzq.y;
        maxY = esqSupDer.y;
    }

    // Update is called once per frame
    void Update()
    {
        //Verificar posición
        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, minX, maxX),
            Mathf.Clamp(transform.position.y, minY, maxY)
            );
        
    }

    private void FixedUpdate()
    {
        myBody.velocity = new Vector2(speed,myBody.velocity.y);
        if (transform.position.x == maxX)
        {
            speed = -3;
        }
        if(transform.position.x == minX)
        {
            speed = 3;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Bullet(Clone)"))
        {
            int newLifePts = lifePoints - 1;

        }
    }
}
