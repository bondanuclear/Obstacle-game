using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObstacle : MonoBehaviour
{
    float timeToElapse = 3f;
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    bool objectDropped;
    // Start is called before the first frame update
    void Start()
    {
        objectDropped = false;
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!objectDropped) {
        if(timeToElapse < Time.time) {
            Debug.Log("3 seconds have elapsed");
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
            objectDropped = true;
            }
        }
       // Debug.Log(Time.time);
    }
}
