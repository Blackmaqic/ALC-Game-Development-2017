using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class flashlight : MonoBehaviour {
 
 public bool lightOn;

 Light light;

 void Start() {
	 light = GetComponent<Light> ();
//set light default on
	 lightOn = true;
	 light.enabled = true;
 }

		//Update is called once per frame
		void Update() {
			//Toggle light on/off when L key is pressed
			else if (Input.GetKeyUp (KeyCode.F)&& !lightOn )) {
				lightOn= true;
				light.enabled = true;

			}

		}

	 
	 }
 }
	
	

