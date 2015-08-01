using UnityEngine;
using System.Collections;

public class HumanPlayer : Player {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			RaycastHit hit;
			Physics.Raycast (this.transform.position, this.transform.forward, out hit, 100000);
			if (hit.collider) {
				//Rigidbody rigidbody = hit.collider.gameObject.GetComponent<Rigidbody> ();
				//if (rigidbody) {
				//	rigidbody.AddExplosionForce(10000, hit.collider.gameObject.transform.position, 1000);
				//}
				Splittable cube = hit.collider.gameObject.GetComponent<Splittable> ();
				if (cube) {
					cube.Split ();
				}
				Spawner spawn = hit.collider.gameObject.GetComponent<Spawner> ();
				if (spawn) {
					spawn.Spawn();
				}
			}
		}
	}
}
