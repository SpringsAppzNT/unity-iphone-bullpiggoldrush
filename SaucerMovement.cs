using UnityEngine;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;

public class BeamMovement : MonoBehaviour {
	public static float maxSpeed = 10f;
	float beamBoundaryRadius = 0.6f;
	public Sprite original;
	public Sprite red;
	public Sprite blue;
	public Sprite yellow;
	public Sprite pink;
	public Sprite purple;

	// Use this for initialization
	void Start () {
		if (GameCtrl.control.oBeam) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = original;
		} else if (GameCtrl.control.redBeam) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = red;
		} else if (GameCtrl.control.blueBeam) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = blue;
		} else if (GameCtrl.control.yellowBeam) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = yellow;
		} else if (GameCtrl.control.pinkBeam) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = pink;
		} else if (GameCtrl.control.purpleBeam) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = purple;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		//pos.x += CrossPlatformInputManager.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
		pos.x += Input.acceleration.x * maxSpeed * Time.deltaTime;
		float screenRatio = (float) Screen.width / (float) Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;

		if (pos.x + beamBoundaryRadius > widthOrtho) {
			pos.x = widthOrtho - beamBoundaryRadius;
		}
		if (pos.x - beamBoundaryRadius < -widthOrtho) {
			pos.x = -widthOrtho + beamBoundaryRadius;
		}
		if (Input.acceleration.x < 0 && !Counter.pause) {
			gameObject.GetComponent<SpriteRenderer>().flipX = true;
		} else if (Input.acceleration.x > 0 && !Counter.pause) {
			gameObject.GetComponent<SpriteRenderer>().flipX = false;
		}

		transform.position = pos;
	}
}
