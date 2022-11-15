using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player")) {
        Debug.Log("Hit the wall");
        GetComponent<MeshRenderer>().material.color = Color.cyan;
        gameObject.tag = "Hit";
        }  
    }
}
