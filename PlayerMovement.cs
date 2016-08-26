using UnityEngine;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {
	public static float maxSpeed = 10f;
	float pigBoundaryRadius = 0.6f;
	public Sprite bullpig;
	public Sprite pigPig;
	public Sprite cowPig;
	public Sprite bunnyPig;
	public Sprite goldPig;
	public Sprite devilPig;

	// Use this for initialization
	void Start () {
		if (GameCtrl.control.bullPig) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = bullpig;
		} else if (GameCtrl.control.pigPig) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = pigPig;
		} else if (GameCtrl.control.cowPig) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = cowPig;
		} else if (GameCtrl.control.bunnyPig) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = bunnyPig;
		} else if (GameCtrl.control.goldPig) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = goldPig;
		} else if (GameCtrl.control.devilPig) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = devilPig;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		//pos.x += CrossPlatformInputManager.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
		pos.x += Input.acceleration.x * maxSpeed * Time.deltaTime;
		float screenRatio = (float) Screen.width / (float) Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;

		if (pos.x + pigBoundaryRadius > widthOrtho) {
			pos.x = widthOrtho - pigBoundaryRadius;
		}
		if (pos.x - pigBoundaryRadius < -widthOrtho) {
			pos.x = -widthOrtho + pigBoundaryRadius;
		}
		if (Input.acceleration.x < 0 && !Counter.pause) {
			gameObject.GetComponent<SpriteRenderer>().flipX = true;
		} else if (Input.acceleration.x > 0 && !Counter.pause) {
			gameObject.GetComponent<SpriteRenderer>().flipX = false;
		}

		transform.position = pos;
	}
}
