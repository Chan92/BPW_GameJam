using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour{
	public float moveSpeed = 10;

    void Update(){
		MoveLevel();
	}

	//fake the character movement by moving the level the opposite direction
	void MoveLevel() {
		Vector3 newpos = new Vector3(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime, transform.position.z);
		transform.position = newpos;
	}
}
