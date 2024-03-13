using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private float directionY;
    private Vector2 direction;


    void Update()
    {
        directionY = Input.GetAxisRaw("Vertical");
        direction = new Vector2(0f, directionY).normalized;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0f, direction.y * speed);
        //Funcion agregada para limitar el movimiento del jugador.
        rb.position = new Vector2 (rb.position.x,Mathf.Clamp(rb.position.y, -3.81f,3.81f));
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Golpe detectado");
    }
}
