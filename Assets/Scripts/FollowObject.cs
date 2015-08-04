using UnityEngine;
using System.Collections;

public class FollowObject : MonoBehaviour {

	public GameObject following;
	public float force;
	// Use this for initialization
	void Start () {
		if (following == null) {
			following = GameObject.Find ("Player");
		}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 diff = following.transform.position - transform.position;
		diff = Vector3.Normalize (diff) * force * Time.deltaTime;
		Rigidbody body = GetComponent<Rigidbody> ();
		body.AddForce (diff);
	}
}
