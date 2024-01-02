using System.Collections;   
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public LogicManagerScript LogicManager;

    void Start()
    {
        LogicManager = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            LogicManager.AddScore(1);
        }
    }
}
