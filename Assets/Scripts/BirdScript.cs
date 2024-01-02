using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdBody;
    public float volcity;
    public LogicManagerScript LogicManager;
    public bool BirdEnabled = true;

    // Start is called before the first frame update
    void Start()
    {
        LogicManager = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && BirdEnabled)
        {
            birdBody.velocity = Vector2.up * volcity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        LogicManager.GameOver();
        BirdEnabled = false;
    }
}
