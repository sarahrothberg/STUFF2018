using UnityEngine;
using System.Collections;

public class KeyPress : MonoBehaviour {

	public GameObject keyboard;

	public GameObject[] keys;
	public AudioClip[] bells;

	private float originalY;
	private float downY;

	// Use this for initialization
	void Start () {
		originalY = keys [0].transform.position.y;
		downY = originalY - 0.01f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			//choose a random key
			int index = Random.Range (0, keys.Length);
			GameObject randomKey = keys[index];
			Vector3 currentPos = randomKey.transform.position;
			currentPos.y = downY;
			randomKey.transform.position = currentPos;
			GetComponent<AudioSource>().clip = bells[Random.Range(0, bells.Length)];
			GetComponent<AudioSource>().pitch = Random.Range(.2f, 2f);
			GetComponent<AudioSource> ().Play ();
			StartCoroutine (keyup (randomKey));
		}

	}

	IEnumerator keyup(GameObject downkey){
		yield return new WaitForSeconds(0.2f);
		Vector3 currentPos = downkey.transform.position;
		currentPos.y = originalY;
		downkey.transform.position = currentPos;
	}
}
