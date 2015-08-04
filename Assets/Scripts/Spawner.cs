using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject Spawning;
	public Material notReadyToSpawn;
	public Material readyToSpawn;
	private float lastSpawned;
	public float spawnTime;
	// Use this for initialization
	void Start () {
		lastSpawned = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - lastSpawned > spawnTime) {
			GetComponent<Renderer> ().material = readyToSpawn;
			GetComponent<Light> ().enabled = true;
		} else {
			GetComponent<Renderer> ().material = notReadyToSpawn;
			GetComponent<Light> ().enabled = false;
		}
	
	}

	public void Spawn() {
		if (Time.time - lastSpawned > spawnTime) {
			lastSpawned = Time.time;
			GameObject spawned = Instantiate (Spawning, transform.position, transform.rotation) as GameObject;
			spawned.GetComponent<FollowObject>().enabled = true;
		}
	}
}
