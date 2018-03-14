﻿using UnityEngine;
using System.Collections;

public class GhostAI : MonoBehaviour {

	public float moveSpeed;

	public Transform target;

	public int damage;

	void OnTriggerStay(Collider other){
		if(other.gameObject.name == "player"){
			Follow();
		}
		else{
			print("Ghost is grounded");
			wander();
		}
	}
	
	void Wander(){
		transform.Translate(Vector3.froward*moveSpeed*Time.deltaTime);
		int randomNum = Random.Range(0,360);
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		RaycastHit hit;

		Debug.DrawRay(transform.postition,fwd*3,Color.red);

		if(Physics.Raycast(transform.position,fwd,out hit,3)){

			if(hit.collider.tag == "wall"){
				transform.Rotate(0,randomNum,0);
			}
		}
	}

	void Follow(){
		transform.LookAt(target);
		transform.Translate(Vecotor3.forward*moveSpeed*Time.deltaTime);
	}


}
