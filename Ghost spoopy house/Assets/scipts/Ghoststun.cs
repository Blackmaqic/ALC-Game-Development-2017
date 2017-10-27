using UnityEngine;
using System.Collections;

public class Ghoststun : MonoBehaviour {

	bool lightCheck;
	flashlight flash;
	public GameObject ghost;


	// Use this for initialization
	void Start () {
	flash = gameObject.GetComponentInChildren<Light>().GetComponentInChildren<flashlight>();
		
		print("Obj:"+flash);
		flash.setLightOn();
		print("Start" + flash.isLightOn());
	}
	//LightCheck = GetComponent<flashlight>().lightOn;
	
	
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		print(other.gameObject.name);
		print ("Collider" + flash);
		
		if(other.gameObject.name == "Ghost" && flash == true ){
			print("Ghost is stunned RUN!");
			// other.GetComponent<Rigidbody>().velocity = vector3.zero;
			// other.GetComponent<Rigidbody>().angularVelocity = vector3.zero;
		
		
		
		
		
			other.GetComponent<GhostAI>().moveSpeed = 0f;
			StartCoroutine(Wait(5, other));
			// StopCoroutine(Wait(5));
		}
	}	
			IEnumerator Wait(float time, Collider other){
					yield return new WaitForSeconds(time);
					other.GetComponent<GhostAI>().moveSpeed = 5f;
					print("Ghost is unstunned");
			}




		
	
}
