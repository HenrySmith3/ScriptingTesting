using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class ControllerInput : InputController {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Physics.Raycast (this.transform.position, this.transform.forward, out hit, 100000);
			if (hit.collider) {
				Trigger trigger = hit.collider.gameObject.GetComponent<Trigger> () as Trigger;
				if (trigger) {
					trigger.DoAction ();
				}
			}
		}
	}
	
	public override Vector2 GetMovementInput() {
		return new Vector2
		{
			x = Input.GetAxis("1LeftH"),
			y = Input.GetAxis("1LeftV")
		};
	}
	
	public override Vector2 GetCameraInput() {
		return new Vector2
		{
			x = Input.GetAxis("1RightH"),
			y = Input.GetAxis("1RightV")
		};
	}
}
