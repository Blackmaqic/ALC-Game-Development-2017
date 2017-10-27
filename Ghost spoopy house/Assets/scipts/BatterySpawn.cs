using UnityEngine;
using System.Collections;

public class BatterySpawn : MonoBehaviour {

	public GameObject battery;

	public Transform spawnPoint;

	public float spawnTime;

	public bool batSpawned; 


	// Use this for initialization
	void Start () {
		 batSpawned = false; 
	}
	
	// Update is called once per frame
	void Update () {
		if(batSpawned == false){
			StartCoroutine(SpawnBat());
		}
		else{
			print("");
		}
	}

	void OnTriggerEnter(Collision other){
		if(other.GameObject.Tag ==""){
			batSpawned == True;
		}
		else{
			batSpawned == False;
		}
	}



	IEnumerator SpawnBat(float time, Rigidbody bat){
			yield return new WaitForSeconds(spawnTime);
			Rigidbody clone;
			(Rigidbody)Instantiate(batter, spawnPoint.position, spawnPoint.rotation);
	}


}
