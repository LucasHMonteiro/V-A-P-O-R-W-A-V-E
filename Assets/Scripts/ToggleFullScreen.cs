using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFullScreen : MonoBehaviour {

	void Start () {
	}

	void Update () {
		if(Input.GetKeyUp(KeyCode.F))
			Screen.fullScreen = !Screen.fullScreen;
	}

}
