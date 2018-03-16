using UnityEngine;
using StateNamespace;

public class StateTemplate : State<MainController>
{
	//declaread one time
	private static StateTemplate _instance;

	//constructor
	private StateTemplate()
	{
		if (_instance != null)
		{
			return;
		}
		//the first and only time this gets constructed it gets set to this instance of the state 
		_instance = this;
	}

	public static StateTemplate Instance
	{
		get
		{
			if (_instance == null)
			{
				new StateTemplate();
			}
			return _instance;
		}
	}


	public override void EnterState(MainController _mainController)
	{
		Debug.Log("Entering First State");
	}

	public override void ExitState(MainController _mainController)
	{
		Debug.Log("Exiting First State");
	}

	public override void UpdateState(MainController _mainController)
	{

	}

}
