using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("Cube");
        obj.tag = "Changed";


        if (obj.CompareTag("Changed"))
        {
            Debug.Log("Tag is Changed");
            obj.name = "changed";
        }
        Destroy(GetComponent<Task1>());
    }

}
