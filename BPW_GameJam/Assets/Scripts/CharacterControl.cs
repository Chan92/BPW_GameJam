using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour{
	public float moveSpeed = 10;
	public Animator anim;

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

		if(Input.GetButtonDown("LeftHand")) {
			LeftHand();
		}

		if(Input.GetButtonDown("RightHand")) {
			RightHand();
		}

		if(Input.GetButtonUp("LeftHand")) {
			anim.SetBool("L", false);
		}
		if(Input.GetButtonUp("RightHand")) {
			anim.SetBool("R", false);
		}
		if(Input.GetButtonUp("Jump")) {
			anim.SetBool("jump", false);
		}

	}

	//playermove
	void Movement() {
		Vector3 newpos = new Vector3(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime, transform.position.z);
		transform.position = newpos;
	}

	//jump
	void Jump() {
		anim.SetBool("jump", true);
		if(jumpblock != null) {
			Destroy(jumpblock);
		}
	}

	//sticks out left hand
	void LeftHand() {
		anim.SetBool("L", true);
		if(newDoor != null) {
			Destroy(newDoor);
		}
	}

	//sticks out right hand
	void RightHand() {
		anim.SetBool("R", true);
		if(newDoor != null) {
			Destroy(newDoor);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.tag == "Doorkey") {
			newDoor = collision.transform.GetChild(0).gameObject;
		}

		if(collision.tag == "Jump") {
			jumpblock = collision.transform.GetChild(0).gameObject;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		gameover = true;
	}
}
