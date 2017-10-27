using UnityEngine;
using System.Collections;

public class smoothcamra : MonoBehaviour {
	[serializerField]Transform target;
	[serializerField]Vector3 defaultDistance = new Vector3(0f,2f, -10f);
	[serializerField]float distanceDamp = 10f;

	Transform myT;


	void Awake()
	{
		myT = transform;
	}	



	void LateUpdate()
	{
		Vector3 toPos = target.position + (target.rotation * defaultDistance);
		Vector3 curPos = Vector3.Lerp(myT.position, toPos, distanceDamp * Time.deltaTime);
		myT.position = curPos;

		Quaternion toRot = Quaternion.LookRotation(target.position - myT.position, target.up)
		Quaternion curPos = Quaternion.Slerp(myT.rotation, toRot, rotationDamp * Time.deltaTime);
		myT.rotation = curRot;
	}


}
