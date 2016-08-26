using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	float rotSpeed = 90f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion rot = transform.rotation;
		float z = rot.eulerAngles.z;
		z += rotSpeed * Time.deltaTime;
		rot = Quaternion.Euler (0, 0, z);
		transform.rotation = rot;
	}
}
