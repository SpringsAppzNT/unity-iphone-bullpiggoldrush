using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {
	float delay = 0.5f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, delay);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
