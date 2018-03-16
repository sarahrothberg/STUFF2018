//using UnityEngine;
//using StateNamespace;

//public class ThirdState : State<MainController>
//{
//	//declaread one time
//	private static ThirdState _instance; 

//	//constructor
//	private ThirdState()
//	{
//		if (_instance != null)
//		{
//			return;
//		}
//		//the first and only time this gets constructed it gets set to this instance of the state 
//		_instance = this; 
//	}

//	public static ThirdState Instance
//	{
//		get
//		{
//			if(_instance == null)
//			{
//				new ThirdState(); 
//			}
//			return _instance;
//		}
//	}
			

//	public override void EnterState(MainController _mainController)
//	{
//		_mainController._appState = AppStates.Third;
//		Debug.Log("Entering Third State"); 
//	}

//	public override void ExitState(MainController _mainController)
//	{
//		Debug.Log("Exiting Third State");
//	}

//	public override void UpdateState(MainController _mainController)
//	{
//		Debug.Log("third state!");
//	}

//}
