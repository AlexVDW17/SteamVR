using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decelerate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 v = this.GetComponent<Rigidbody>().velocity;
        Vector3 a = this.GetComponent<Rigidbody>().angularVelocity;

        this.GetComponent<Rigidbody>().velocity = new Vector3(v.x*0.90f, v.y * 0.90f, v.z * 0.90f);
        //this.GetComponent<Rigidbody>().angularVelocity = new Vector3(a.x * 0.95f, a.y * 0.95f, a.z * 0.95f);
    }
}
