using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3f;
    private float timer = 0;
    public float heightOffest = 9;
    public bool spawn = false;
    public Logic logic;
    public int counter;
    public int threshold = 9;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logic>();
        // spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.gameDone)
        {
            spawn = false;
        }
        spawn = logic.start();
        if (timer<spawnRate){
            timer+= Time.deltaTime;
        }
        else{
        spawnPipe();
        timer = 0;
        }
        if (int.Parse(logic.Score.text) > threshold)
        {
            increaseDiffculty();
        }

    }

    void spawnPipe(){
        if (spawn)
        {
            float lowestPoint = transform.position.y - heightOffest;
            float highestPoint = transform.position.y + heightOffest;
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
            counter++;
        }

    }

    void increaseDiffculty()
    {
        spawnRate = spawnRate - 0.2f;
        threshold = threshold + 5;
    }
}
