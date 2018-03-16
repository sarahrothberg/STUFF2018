using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.PostProcessing;


namespace MainControllerNS
{
	public class MainController : MonoBehaviour
	{
		public GameObject[] appStateControllers;

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
		}

		void Update()
		{
			if (Input.GetKeyDown("1"))
			{
				foreach (GameObject appState in appStateControllers)
				{
					appState.SetActive(false);
				}
				appStateControllers[0].SetActive(true);
			}
			if (Input.GetKeyDown("2"))
			{
				foreach (GameObject appState in appStateControllers)
				{
					appState.SetActive(false);
				}
				appStateControllers[1].SetActive(true);
			}
			if (Input.GetKeyDown("3"))
			{
				foreach (GameObject appState in appStateControllers)
				{
					appState.SetActive(false);
				}
				appStateControllers[2].SetActive(true);
			}
		}

		public void ResetVisuals()
		{
			var chromatiAbb = _postProcessingProfile.chromaticAberration.settings;
			chromatiAbb.intensity = 0;
			_postProcessingProfile.chromaticAberration.settings = chromatiAbb;
		}
	}
}