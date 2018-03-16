using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.PostProcessing;
using StateNamespace;


public enum AppStates { First, Second, Third };

public class MainController : MonoBehaviour
{
	public AppStates _appState;

	public StateMachine<MainController> stateMachine { get; set; }

	public GameObject keyboard; 

	public AudioSource linesPlayer; 
	public AudioClip[] introLines;

	public GameObject[] stuff;
	public Color[] colors;
	public GameObject stuffSign;

	public float gameTimer;
	public int seconds = 0;

	public PostProcessingProfile _postProcessingProfile;
	public Material everything;


	void Start()
	{
		ResetVisuals();
		Cursor.visible = false;

		stateMachine = new StateMachine<MainController>(this);
		gameTimer = Time.time;

		switch (_appState)
		{
			case AppStates.First:
				stateMachine.ChangeState(FirstState.Instance);
				break;
			case AppStates.Second:
				stateMachine.ChangeState(SecondState.Instance);
				break;
			case AppStates.Third:
				stateMachine.ChangeState(ThirdState.Instance);
				break;
		}
	}

	void Update()
	{
		if (Input.GetKeyDown("1"))
		{
		stateMachine.ChangeState(FirstState.Instance);

		}
		if (Input.GetKeyDown("2"))
		{
		stateMachine.ChangeState(SecondState.Instance);

		}
		if (Input.GetKeyDown("3"))
		{
		stateMachine.ChangeState(ThirdState.Instance);
		}

		stateMachine.Update();
	}

	public void ResetVisuals()
	{
		var chromatiAbb = _postProcessingProfile.chromaticAberration.settings;
		chromatiAbb.intensity = 0;
		_postProcessingProfile.chromaticAberration.settings = chromatiAbb;
	}
}