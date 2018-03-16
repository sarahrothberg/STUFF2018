using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainControllerNS;
using CoroutineUtilsNamespace; 

public class State1Controller : MonoBehaviour
{

	GameObject stuffController;
	MainController _mainController;
	GameObject thing;

	public AudioClip appearClip; 

	void OnEnable()
	{
		stuffController = GameObject.Find("StuffController");
		_mainController = stuffController.GetComponent<MainController>();
		_mainController.linesPlayer.clip = _mainController.introLines[Random.Range(0, _mainController.introLines.Length)];
		_mainController.linesPlayer.Play();
	}

	void Update()
	{
		if (_mainController.linesPlayer.time == _mainController.linesPlayer.clip.length)
		{
			StartCoroutine(CoroutineUtils.DelaySeconds(() =>
			{
				Vector3 position = new Vector3(0, .5f, 3f);
				thing = Instantiate(_mainController.stuff[Random.Range(0, _mainController.stuff.Length)], position, new Quaternion(0, 0, 0, 0));
				thing.GetComponent<AudioSource>().clip = appearClip;
				thing.GetComponent<AudioSource>().Play(); 
				thing.GetComponent<Rigidbody>().isKinematic = true;
			}, (1f)));

			
		}

	}

	private void OnDisable()
	{
		Debug.Log(this.name + "disabled");
		var settings = _mainController._postProcessingProfile.colorGrading.settings;
		settings.basic.postExposure = 0;
		_mainController._postProcessingProfile.colorGrading.settings = settings;
		Object.Destroy(thing);
	}
}
