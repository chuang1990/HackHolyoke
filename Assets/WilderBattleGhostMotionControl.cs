using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WilderBattleGhostMotionControl : MonoBehaviour
{
 	public float deltaX;
 	public float deltaY;
    // Use this for initialization
    void Start () {
 
 		deltaX = 0.1f;
 		deltaY = 0.0f;
    }
 
    // Update is called once per frame
    void Update () {
		transform.position += new Vector3(deltaX,deltaY,0) ;

		Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
		pos.x %= 1;
		// pos.y %= 1;
		transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
    private void FixedUpdate() { 
    	/* Called every Fixed Timestep */ 
    	deltaX = Random.Range(0.1f, -0.1f);
    	// deltaY = Random.Range(0.1f, -0.1f);

    }

}
