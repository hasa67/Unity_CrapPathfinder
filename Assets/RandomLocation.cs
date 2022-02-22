using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		print ("collided");
		if (other.tag == "Enemy") {
			Vector2 newPosition = new Vector2 (Random.Range (-2f, 2f), Random.Range (-4f, 4f));
			transform.position = newPosition;
		}
	}
}
