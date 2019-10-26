using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public float speed = 2;
    public float speedJoystick = 5f;
    public Vector3 movimiento;
    public Vector3 JoystickMove;



    public bool movingLeft = false;
    public bool movingRight = false;


    // Use this for initialization
    void Start()
    {

    }

    public void Movimiento1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            rb.transform.eulerAngles = new Vector3(0, 180, 0);
            movimiento.x = -1f;
            JoystickMove.x = -1f;
            movingRight = false;
            movingLeft = true;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            rb.transform.eulerAngles = new Vector3(0, 0, 0);
            movimiento.x = 1f;
            JoystickMove.x = 1f;
            movingLeft = false;
            movingRight = true;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0, speed * -1);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }

    }

    private void Update()
    {

        Movimiento1();

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        float mH = Input.GetAxisRaw("Horizontal");
        float mV = Input.GetAxisRaw("Vertical");

        //movimiento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        //transform.position = transform.position + movimiento * Time.deltaTime * speed;

        //float movehorizontal = input.getaxisraw("Horizontal");

        //float movevertical = input.getaxisraw("Vertical");

        //rb.velocity = new vector3(movehorizontal * speed, rb.velocity.y, movevertical * speed);//
        rb.velocity = new Vector3(mH * speed, rb.velocity.y, mV * speed);

    }

}

