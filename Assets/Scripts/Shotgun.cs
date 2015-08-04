using UnityEngine;
using System.Collections;

public class Shotgun : MonoBehaviour {
	public GameObject Spawning;
	public GameObject ShootAt;
	public Material notReadyToSpawn;
	public Material readyToSpawn;
	private float lastSpawn;
	public float spawnTime;
	public int numSpawn;
	public float spawnRange;
	public float power;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - lastSpawn > spawnTime) {
			GetComponent<Renderer> ().material = readyToSpawn;
			GetComponent<Light> ().enabled = true;
			
		} else {
			GetComponent<Renderer> ().material = notReadyToSpawn;
			GetComponent<Light> ().enabled = false;
		}
		
	}
	
	public void Shoot() {
		if (Time.time - lastSpawn > spawnTime) {
			lastSpawn = Time.time;
			for(int i = 0; i<numSpawn; i++) {
				Vector3 newPosition = transform.position
					+ new Vector3(
						(i*1.0f/numSpawn) * spawnRange, //Space along 1 dimension to avoid collision.
						Random.value * spawnRange,
						Random.value * spawnRange);
				GameObject spawned = Instantiate (Spawning, newPosition, transform.rotation) as GameObject;
				Vector3 force = Vector3.Normalize(ShootAt.transform.position - spawned.transform.position) * power;
				force.x += (float)(Random.value - .5) * .01f;
				force.y += (float)(Random.value - .5) * .01f;
				force.z += (float)(Random.value - .5) * .01f;
				spawned.GetComponent<Rigidbody>().AddForce(force);
			}
		}
	}
}
