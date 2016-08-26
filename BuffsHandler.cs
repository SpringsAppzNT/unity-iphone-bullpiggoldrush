using UnityEngine;
using System.Collections;

public class BuffsHandler : MonoBehaviour {
	public static float speedTimer;
	public static float speedDBTimer;
	public static float slomoTimer;
	public static float doubleGoldTimer;
	public GameObject hammerPrefab;

	void OnTriggerEnter2D(Collider2D player){
		if (player.gameObject.tag == "Player") {
			if (this.gameObject.tag == "HealthPack") {
				AddOneHealth ();
			} else if (this.gameObject.tag == "SpeedBoost") {
				SpeedBoost ();
			} else if (this.gameObject.tag == "SpeedDB") {
				SpeedDB ();
			} else if (this.gameObject.tag == "HammerDB") {
				HammerTime ();
			} else if (this.gameObject.tag == "Slomo") {
				Slomo ();
			} else if (this.gameObject.tag == "DoubleGold") {
				DoubleGold ();
			}
				
		}
	}

	void AddOneHealth(){
		Counter.lives++;
		DamageHandler.health++;
		Destroy (gameObject);
	}

	void SpeedBoost(){
		PlayerMovement.maxSpeed += 8;
		SaucerMovement.maxSpeed += 8;
		BeamMovement.maxSpeed += 8;
		speedTimer = 5;
		Destroy (gameObject);
	}
	void SpeedDB(){
		PlayerMovement.maxSpeed -= 8;
		SaucerMovement.maxSpeed -= 8;
		BeamMovement.maxSpeed -= 8;
		speedDBTimer = 10;
		Destroy (gameObject);

	}
	void HammerTime(){
		float screenRatio = (float) Screen.width / (float) Screen.height;
		//float hscreenRatio = (float)Screen.height / (float)Screen.width;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;
		//float heightOrtho = Camera.main.orthographicSize * hscreenRatio;

		float hammerBoundaryRadius = 0.6f;

		Vector3 position1 = new Vector3 (0, 10);
		Vector3 position2 = new Vector3 (-widthOrtho + hammerBoundaryRadius, 10);
		Vector3 position3 = new Vector3 (widthOrtho - hammerBoundaryRadius, 10);

		Instantiate(hammerPrefab, position1, Quaternion.identity);
		Instantiate(hammerPrefab, position2, Quaternion.identity);
		Instantiate(hammerPrefab, position3, Quaternion.identity);

		Destroy (gameObject);
		
	}
	void Slomo(){
		Counter.slomo = true;
		slomoTimer = 5;
		Destroy (gameObject);
	}
	void DoubleGold(){
		Counter.doubleGold = true;
		doubleGoldTimer = 10;
		Destroy (gameObject);
	}
	void Update(){
		speedTimer -= Time.deltaTime;
		if (speedTimer < 0) {
			PlayerMovement.maxSpeed = 10;
			SaucerMovement.maxSpeed = 10;
			BeamMovement.maxSpeed = 10;
		}

		speedDBTimer -= Time.deltaTime;

		if (speedDBTimer < 0) {
			PlayerMovement.maxSpeed = 10;
			PlayerMovement.maxSpeed = 10;
			SaucerMovement.maxSpeed = 10;
			BeamMovement.maxSpeed = 10;
		}

		slomoTimer -= Time.deltaTime;

		if (slomoTimer < 0) {
			Counter.slomo = false;
		}

		doubleGoldTimer -= Time.deltaTime;

		if (doubleGoldTimer < 0) {
			Counter.doubleGold = false;
		}
	}
}
