using StateNamespace;
using UnityEngine;

public class SecondState : State<MainController>
{
	//declaread one time
	private static SecondState _instance;

	//constructor
	private SecondState()
	{
		if (_instance != null)
		{
			return;
		}

		//the first and only time this gets constructed it gets set to this instance of the state 
		_instance = this;
	}

	public static SecondState Instance
	{
		get
		{
			if (_instance == null)
			{
				new SecondState();
			}
			return _instance;
		}
	}


	public override void EnterState(MainController _mainController)
	{
		_mainController._appState = AppStates.Second;
		Debug.Log("Entering Second State");
		_mainController.keyboard.SetActive(true);
	}

	public override void ExitState(MainController _mainController)
	{
		Debug.Log("Exiting Second State");
		_mainController.keyboard.SetActive(false);

	}

	public override void UpdateState(MainController _mainController)
	{

		if (_mainController._appState == AppStates.Second)
		{
			Debug.Log("second state!");
		}


		if (Input.anyKeyDown)
		{
			var thing = _mainController.stuff[UnityEngine.Random.Range(0, _mainController.stuff.Length)];
			Vector3 position = new Vector3(UnityEngine.Random.Range(-10.0F, 10.0F), 10, UnityEngine.Random.Range(-10.0F, 50.0F));
			UnityEngine.Object.Instantiate(thing, position, UnityEngine.Random.rotation);

			//sound.clip = sounds[Random.Range(0, sounds.Length)];
			//sound.Play();
			_mainController.everything.color = _mainController.colors[UnityEngine.Random.Range(0, _mainController.stuff.Length)];

			var settings = _mainController._postProcessingProfile.colorGrading.settings;
			settings.basic.hueShift = UnityEngine.Random.Range(-180f, 180f);
			_mainController._postProcessingProfile.colorGrading.settings = settings;

			var chromatiAbb = _mainController._postProcessingProfile.chromaticAberration.settings;
			chromatiAbb.intensity = chromatiAbb.intensity + .01f;
			_mainController._postProcessingProfile.chromaticAberration.settings = chromatiAbb;

			var stuffSignTransformPosition = _mainController.stuffSign.transform.position;
			stuffSignTransformPosition.z = _mainController.stuffSign.transform.position.z - .1f;
			_mainController.stuffSign.transform.position = stuffSignTransformPosition;
		}
	}
}