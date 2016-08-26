using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class SlowTime : MonoBehaviour {
	float original;
	private Rigidbody2D body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
		original = body.gravityScale;
	
	}

	// Update is called once per frame
	void Update () {
		if (Counter.slomo) {
			body.gravityScale = original / (float)2;
		} else {
			body.gravityScale = original;
		}
	
	}
}
