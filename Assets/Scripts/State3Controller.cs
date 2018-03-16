using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainControllerNS; 

public class State3Controller : MonoBehaviour {

	GameObject stuffController;
	MainController _mainController;
	GameObject thing;

	void OnEnable()
	{
		stuffController = GameObject.Find("StuffController");
		_mainController = stuffController.GetComponent<MainController>();

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
