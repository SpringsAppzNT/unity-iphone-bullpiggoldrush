using UnityEngine;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;

public class SaucerMovement : MonoBehaviour {
	public static float maxSpeed = 10f;
	float saucerBoundaryRadius = 0.6f;
	public Sprite original;
	public Sprite red;
	public Sprite blue;
	public Sprite yellow;
	public Sprite pink;
	public Sprite purple;

	// Use this for initialization
	void Start () {
		if (GameCtrl.control.oSaucer) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = original;
		} else if (GameCtrl.control.redSaucer) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = red;
		} else if (GameCtrl.control.blueSaucer) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = blue;
		} else if (GameCtrl.control.yellowSaucer) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = yellow;
		} else if (GameCtrl.control.pinkSaucer) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = pink;
		} else if (GameCtrl.control.purpleSaucer) {
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

		if (pos.x + saucerBoundaryRadius > widthOrtho) {
			pos.x = widthOrtho - saucerBoundaryRadius;
		}
		if (pos.x - saucerBoundaryRadius < -widthOrtho) {
			pos.x = -widthOrtho + saucerBoundaryRadius;
		}
		if (Input.acceleration.x < 0 && !Counter.pause) {
			gameObject.GetComponent<SpriteRenderer>().flipX = true;
		} else if (Input.acceleration.x > 0 && !Counter.pause) {
			gameObject.GetComponent<SpriteRenderer>().flipX = false;
		}

		transform.position = pos;
	}
}
