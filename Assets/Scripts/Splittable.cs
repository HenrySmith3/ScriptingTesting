using UnityEngine;
using System.Collections;

public class Splittable : MonoBehaviour {
	public float rotatespeed;
	public int numChildren;
	public int splitsLeft;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, rotatespeed * Time.deltaTime);
	
	}

	public void Split() {
		if (splitsLeft > 0) {
			splitsLeft--;
			Splittable[] children = new Splittable[numChildren];
			for (int i = 0; i < numChildren; i++) {
				children [i] = Instantiate (this, generateNewPosition(), new Quaternion()) as Splittable;
				children[i].transform.localScale = transform.localScale + new Vector3(-.8f,-.8f,-.8f);
			}
		}
		Destroy (gameObject);
	}

	private Vector3 generateNewPosition() {
		Vector3 randomOffset = new Vector3 (
			Random.value * 3,
			Random.value,
			Random.value * 3
		);
		return transform.position + randomOffset;
	}
}
