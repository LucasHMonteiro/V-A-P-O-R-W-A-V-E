using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public Transform projectile;
	public float cooldown = 0.5f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
			Instantiate(projectile, new Vector3 (transform.position.x, transform.position.y, transform.position.z+0.2f), Quaternion.Euler(-90, 0, 0));
		}
	}
}
