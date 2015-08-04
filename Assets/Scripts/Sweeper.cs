using UnityEngine;
using System.Collections;

public class Sweeper : MonoBehaviour {
	public GameObject Sweeping;
	public Material notReadyToSpawn;
	public Material readyToSpawn;
	private float lastSweep;
	public float sweepTime;
	// Use this for initialization
	void Start () {
		lastSweep = -999;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - lastSweep > sweepTime) {
			GetComponent<Renderer> ().material = readyToSpawn;
			GetComponent<Light> ().enabled = true;
			/*if (sweeping) {
				sweeping = false;
				Sweeping.GetComponent<Rigidbody> ().velocity = Vector3.zero;
				sweepRight = !sweepRight;
			}*/

		} else {
			GetComponent<Renderer> ().material = notReadyToSpawn;
			GetComponent<Light> ().enabled = false;
			/*if (sweeping) {
				Sweeping.GetComponent<Rigidbody> ().AddForce (sweepRight ? Vector3.back*100000 : Vector3.back*-100000);
			}*/
		}
		
	}
	
	public void Sweep() {
		if (Time.time - lastSweep > sweepTime) {
			lastSweep = Time.time;
			//sweeping = true;
			Animation animation = Sweeping.GetComponent<Animation>() as Animation;
			animation.Play();
		}
	}
}
