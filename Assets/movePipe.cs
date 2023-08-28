using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipe : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float deadZone = -12;
    public Logic logic;
    public Rigidbody rb;
    public GameObject Top;
    public GameObject Bottom;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logic>();

    }

    // Update is called once per frame
    void Update()
    {
        if (logic.gameDone)
        {
            rb.useGravity = true;
        }
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if(transform.position.x < deadZone){
            Debug.Log("destroy");
            Destroy(gameObject);
        }

    }


}
