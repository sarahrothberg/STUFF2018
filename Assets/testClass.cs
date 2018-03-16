using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testClass : MonoBehaviour {

	// Use this for initialization
	void OnEnable()
	{
		Debug.Log("enabled"); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDisable()
	{
		Debug.Log("disabled");
	}
}
