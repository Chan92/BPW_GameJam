using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour{
	public float moveSpeed = 10;

	private GameObject newDoor;
	private GameObject jumpblock;
	private bool gameover = false;

	void Update(){
		//always move
		if(!gameover) {
			Movement();
		}

		//do actions upon pressing keys
		if(Input.GetButtonDown("Jump")) {
			Jump();
		}

		if(Input.GetButton("LeftHand")) {
			LeftHand();
		}

		if(Input.GetButton("RightHand")) {
			RightHand();
		}
	}

	//playermove
	void Movement() {
		Vector3 newpos = new Vector3(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime, transform.position.z);
		transform.position = newpos;
	}

	//jump
	void Jump() {
		if(jumpblock != null) {
			Destroy(jumpblock);
		}
	}

	//sticks out left hand
	void LeftHand() {	
		if(newDoor != null) {
			Destroy(newDoor);
			print("test4");
		}
	}

	//sticks out right hand
	void RightHand() {
		if(newDoor != null) {
			Destroy(newDoor);
			print("test3");
		}
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		print("test1");
		if (collision.tag == "Doorkey") {
			newDoor = collision.transform.GetChild(0).gameObject;
			print(newDoor.name);
		}

		if(collision.tag == "Jump") {
			jumpblock = collision.transform.GetChild(0).gameObject;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		gameover = true;
	}
}
