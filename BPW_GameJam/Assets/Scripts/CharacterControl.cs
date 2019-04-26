using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour{

    void Update(){
        if(Input.GetButtonDown("Jump")) {
			Jump();
		}

		if(Input.GetButtonDown("Slide")) {
			Slide();
		}

		if(Input.GetButton("LeftHand")) {
			LeftHand();
		}

		if(Input.GetButton("RightHand")) {
			RightHand();
		}
	}

	//jump
	void Jump() {
	}

	//slide
	void Slide() {
	}

	//sticks out left hand
	void LeftHand() {
	}

	//sticks out right hand
	void RightHand() {
	}
}
