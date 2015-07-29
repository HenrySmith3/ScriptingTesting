using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public GameObject obj;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				Instantiate (obj, new Vector3((i-1)*2,(j-1)*2,0), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
