﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WillowBattleController : MonoBehaviour
{
 	
 	private Vector3 leftAndRight = new Vector3(0.1f,0,0);
 	private Vector3 upAndDown = new Vector3(0,0.1f,0);
    // Use this for initialization
    void Start () {
 		
 
    }
 	
    // Update is called once per frame
    void Update () {

 		if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")) {
 			transform.position -= leftAndRight;
 		}
 		if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")) {
 			transform.position += leftAndRight;
 		}
 		if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w")) {
 			transform.position += upAndDown;
 		}
 		if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey("s")) {
 			transform.position -= upAndDown;
 		}

        if(Input.GetKey("q") || Input.GetKey(KeyCode.Escape)){
            Debug.Log("Exiting");
            Application.Quit();
        }

 		// OnTriggerEnter2D()

    }

    private void OnCollisionEnter(Collision collision) { 
        Debug.Log(gameObject.name + " just hit " 
            + collision.gameObject.name); 
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        // if (collision.relativeVelocity.magnitude > 2)
        //     audioSource.Play();
    }
}
