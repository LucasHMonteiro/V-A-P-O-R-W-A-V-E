using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	public float moveSpeed = 0.5f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float verticalSpeed = Input.GetAxis("Vertical") * moveSpeed;
		float horizontalSpeed = Input.GetAxis("Horizontal") * moveSpeed;
		verticalSpeed *= Time.deltaTime;
		horizontalSpeed *= Time.deltaTime;
		transform.Translate(horizontalSpeed, verticalSpeed, 0);
	}
}
