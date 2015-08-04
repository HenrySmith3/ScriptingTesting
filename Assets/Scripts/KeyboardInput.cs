using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.FirstPerson;

public class KeyboardInput : InputController {
	
	public MouseLook mouseLook = new MouseLook();
	private Camera cam;
	// Use this for initialization
	void Start () {
		cam = gameObject.GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		mouseLook.Init (transform, cam.transform);
		RotateView();
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
			x = CrossPlatformInputManager.GetAxis("Horizontal"),
			y = CrossPlatformInputManager.GetAxis("Vertical")
		};
	}
	
	public override Vector2 GetCameraInput() {
		return new Vector2
		{
			x = CrossPlatformInputManager.GetAxis("Mouse X"),
			y = CrossPlatformInputManager.GetAxis("Mouse Y")
		};
	}

	
	private void RotateView()
	{
		//avoids the mouse looking if the game is effectively paused
		if (Mathf.Abs(Time.timeScale) < float.Epsilon) return;
		
		// get the rotation before it's changed
		float oldYRotation = transform.eulerAngles.y;
		
		mouseLook.LookRotation (transform, cam.transform);
		
		//float angH = Input.GetAxis("RightH") * 5;
		//float angV = Input.GetAxis("RightV") * 4;
		
		//Controller stuff here.
		//Debug.Log ("H: " + angH + "V: " + angV);
		//transform.localEulerAngles += new Vector3(angV, angH, 0);
		
		//if (m_IsGrounded || advancedSettings.airControl)
		//{
		//	// Rotate the rigidbody velocity to match the new direction that the character is looking
		//	Quaternion velRotation = Quaternion.AngleAxis(transform.eulerAngles.y - oldYRotation, Vector3.up);
		//	m_RigidBody.velocity = velRotation*m_RigidBody.velocity;
		//}
	}
}
