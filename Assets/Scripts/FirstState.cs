//using UnityEngine;
//using UnityEngine.Events;
//using System.Collections;
//using CoroutineUtilsNamespace; 
//using StateNamespace;

//public class FirstState : State<MainController>
//{
//	//declaread one time
//	private static FirstState _instance;

//	//constructor
//	private FirstState()
//	{
//		if (_instance != null)
//		{
//			return;
//		}
//		//the first and only time this gets constructed it gets set to this instance of the state 
//		_instance = this;
//	}

//	public static FirstState Instance
//	{
//		get
//		{
//			if (_instance == null)
//			{
//				new FirstState();
//			}
//			return _instance;
//		}
//	}

//	GameObject thing;

//	public override void EnterState(MainController _mainController)
//	{
//		_mainController.linesPlayer.clip = _mainController.introLines[Random.Range(0, _mainController.introLines.Length)];
//		_mainController.linesPlayer.Play();
//	}

//	public override void ExitState(MainController _mainController)
//	{
//		Debug.Log("Exiting First State");


//		var settings = _mainController._postProcessingProfile.colorGrading.settings;
//		settings.basic.postExposure = 0;
//		_mainController._postProcessingProfile.colorGrading.settings = settings;
//		Object.Destroy(thing);
//	}


//	public override void UpdateState(MainController _mainController)
//	{
//		if (_mainController.linesPlayer.time == _mainController.linesPlayer.clip.length)
//		{

//			Vector3 position = new Vector3(0, .5f, 3f);
//			thing = Object.Instantiate(_mainController.stuff[Random.Range(0, _mainController.stuff.Length)], position, new Quaternion(0, 0, 0, 0));
//			thing.GetComponent<Rigidbody>().isKinematic = true;
//		}
//	}
//	public void Test()
//	{

//	}
//}
