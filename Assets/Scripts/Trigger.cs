using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DoAction () {
		Splittable cube = gameObject.GetComponent<Splittable> ();
		if (cube) {
			cube.Split ();
		}
		Spawner spawn = gameObject.GetComponent<Spawner> ();
		if (spawn) {
			spawn.Spawn();
		}
		Sweeper sweep = gameObject.GetComponent<Sweeper> ();
		if (sweep) {
			sweep.Sweep();
		}
		Shotgun shotgun = gameObject.GetComponent<Shotgun> ();
		if (shotgun) {
			shotgun.Shoot();
		}
	
	}
}
