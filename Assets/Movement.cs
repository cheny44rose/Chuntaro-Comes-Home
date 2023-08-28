using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float jumpAmount;
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            rb.velocity = Vector2.up * jumpAmount;
        }
    }
}
