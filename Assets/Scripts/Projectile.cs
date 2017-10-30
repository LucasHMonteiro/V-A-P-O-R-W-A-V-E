using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float moveSpeed = 0.5f;
	public float lifetime = 3;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
		Destroy(gameObject, lifetime);
	}
}
