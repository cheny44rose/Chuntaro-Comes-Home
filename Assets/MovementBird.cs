using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementBird : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float jumpAmount;
    public float tiltAngle;
    public float pressedTilt;
    public Logic logic;
    public bool birdAlive = true;
    public bool move = false;
    public bool pressed = false;
    void Start()
    {
        rb.useGravity = false;
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        move = logic.start();
        if (move)
        {
            transform.Rotate(Vector3.right * tiltAngle);
        }

        rb.useGravity = logic.start();
        if (Input.GetKey("space") && birdAlive && move && !pressed)
        {
            rb.velocity = Vector2.up * jumpAmount;
            transform.Rotate(Vector3.left* pressedTilt);
            pressed = true;
        }
        if (!Input.GetKey("space"))
        {
            pressed = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pipe(Clone)" || collision.gameObject.name == "belowScreen")
        {
           logic.gameOver();
           birdAlive = false;
        }
    }


}

