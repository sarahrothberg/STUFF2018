using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainControllerNS; 

public class State0Controller : MonoBehaviour {

	void OnEnable()
	{
		Debug.Log(this.name + "enabled");
	}

	void Update()
	{

	}

	private void OnDisable()
	{
		Debug.Log(this.name + "disabled");
	}
}
