using UnityEngine;
using System.Collections;

public class Clicker : MonoBehaviour {

	// Use this for initialization
	public bool clicked() {
		//return Cardboard.SDK.CardboardTriggered;
		return Cardboard.SDK.Triggered;
	}
}
