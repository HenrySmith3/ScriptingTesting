using UnityEngine;
using System.Collections;

public abstract class InputController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public abstract Vector2 GetMovementInput();
	public abstract Vector2 GetCameraInput();
}
