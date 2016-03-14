using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EventLook : MonoBehaviour {

	public float timerDuration = 2f;

	public float lookTimer = 0f;

	public bool isLookedAd = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (isLookedAd) {
			lookTimer += Time.deltaTime;
			if (lookTimer > timerDuration) {
				lookTimer = 0f;
				Debug.Log ("¡Que me miras!");
				SceneManager.LoadScene ("Escena1");
				//gameObject.SetActive (false);
			} 
		}else {
			lookTimer = 0f;
		}
	}

	public void SetGazedAt(bool gazedAt){
		isLookedAd = gazedAt;
	}
}
