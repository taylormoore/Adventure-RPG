using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** This script is attached to the Player Input game object that is included in every 
  * scene. My thinking was that any other object that requires player input (e.g. player,
  * UI stuff, battling stuff) will all be able to reach to this object to get whatever
  * input that they need, rather than hard coding player input into each game object. 
  * The names and properties of our Input axes and buttons are found in Edit >> 
  * Project Settings >> Input. */

public class PlayerInput : MonoBehaviour {

	public float horizontalAxis = 0;
	public float verticalAxis = 0;
	
	void Start() {
		DontDestroyOnLoad(gameObject);
	}

	void Update () {
		horizontalAxis = Input.GetAxis("Horizontal");
		verticalAxis = Input.GetAxis("Vertical");
	}
}
