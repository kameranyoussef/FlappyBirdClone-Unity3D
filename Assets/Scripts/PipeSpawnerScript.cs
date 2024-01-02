using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate; 
    public float spawnTimer;
    public float heightOffset;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer < spawnRate)
        {
            spawnTimer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            spawnTimer = 0;
        }

    }

    void spawnPipe() 
    {
        float lowsetPoint = transform.position.y - heightOffset;
        float heighsetPoint = transform.position.y + heightOffset;
        Instantiate(pipe, 
            new Vector3(transform.position.x,Random.Range(lowsetPoint,heighsetPoint),0),
            transform.rotation
            );
    }
}
