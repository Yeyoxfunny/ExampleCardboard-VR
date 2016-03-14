using UnityEngine;
using System.Collections;

public class HeadLookWalk : MonoBehaviour {

	public float velocity = 0.99f;
	public bool isWalking = false;

	private CharacterController controller;
	private Clicker clicker = new Clicker ();

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		/*Vector3 moveDirection = Camera.main.transform.forward;
		moveDirection *= velocity * Time.deltaTime;
		moveDirection.y = 0.0f;
		//Esta línea no se necesita, se remplaza con la de abajo: transform.position += moveDirection;
		//controller.Move (moveDirection);
		controller.SimpleMove (Camera.main.transform.forward * velocity);*/
		if (clicker.clicked ()) {
			isWalking = !isWalking;
			//Debug.Log (isWalking);
		} else {
			controller.SimpleMove (Camera.main.transform.forward * velocity);
		}
		cambio ();
	}

	void cambio(){
		if (!isWalking)
			velocity = 0.0f;
		else
			velocity = 0.99f;
	}
}
