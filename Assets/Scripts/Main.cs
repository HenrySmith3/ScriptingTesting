﻿using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	public Texture2D crosshairTexture;
	public float crosshairScale = 1;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
			 
	}

	void OnGUI() {
		GUI.DrawTexture(new Rect((Screen.width-crosshairTexture.width*crosshairScale)/2 ,(Screen.height-crosshairTexture.height*crosshairScale)/4, crosshairTexture.width*crosshairScale, crosshairTexture.height*crosshairScale),crosshairTexture);
		GUI.DrawTexture(new Rect((Screen.width-crosshairTexture.width*crosshairScale)/2 ,(Screen.height-crosshairTexture.height*crosshairScale)*3/4, crosshairTexture.width*crosshairScale, crosshairTexture.height*crosshairScale),crosshairTexture);
	}

}
