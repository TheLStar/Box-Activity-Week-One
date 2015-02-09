using UnityEngine;
using System.Collections;

public class ColourChange : MonoBehaviour {


	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
						gameObject.renderer.material.color = Color.red;
				}
	
	}
}
