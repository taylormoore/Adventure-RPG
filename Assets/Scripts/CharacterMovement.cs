using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** This class reaches out to the Player Input game object and applies basic movement
  * based off of that. The names and properties of our Input axes and buttons are found in
  * Edit >> Project Settings >> Input. */

public class CharacterMovement : MonoBehaviour {

	PlayerInput playerInput;

	[SerializeField]
	float movementSpeed;

	void Start () {
		playerInput = GameObject.Find("Player Input").GetComponent<PlayerInput>();
	}
	
	void Update () {

		transform.Translate(Vector2.up * playerInput.verticalAxis * movementSpeed * Time.deltaTime);

		transform.Translate(Vector2.right * playerInput.horizontalAxis * movementSpeed * Time.deltaTime);
	}
}
