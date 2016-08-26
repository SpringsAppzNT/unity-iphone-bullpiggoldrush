using UnityEngine;
using System.Collections;

public class ChangePositionJoyStick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 pos = transform.position;
		pos.x = Screen.width / 2;
		pos.y = 20; 
		transform.position = pos;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
