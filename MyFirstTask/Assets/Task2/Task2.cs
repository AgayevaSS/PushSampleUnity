using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<MeshRenderer>().enabled = false;
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<MeshRenderer>().enabled = true;
        other.tag = "Entered";
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.name = "Empty";
        collision.transform.parent = transform;
    }
}
