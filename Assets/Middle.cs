using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : MonoBehaviour
{
    public Logic logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logic>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision){
        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }

    }
}
