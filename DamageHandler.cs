using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class DamageHandler : MonoBehaviour {
	public static int health = 3;
	public float invulnPeriod = 2;
	float invulnTimer = 0;
	int correctLayer;
	private int frames = 0;
	public AudioClip impact;
	public AudioClip coinDrop;
	public AudioClip powerUp;
	public AudioClip evilLaugh;
	AudioSource audios;
	AudioSource audios1;
	AudioSource audios2;
	AudioSource audios3;

	SpriteRenderer spriteRend;

	void Start(){
		
		correctLayer = gameObject.layer;

		spriteRend = GetComponent<SpriteRenderer> ();
		if (spriteRend == null) {
			spriteRend = transform.GetComponentInChildren<SpriteRenderer> ();

			if (spriteRend == null) {
				Debug.LogError ("Object '" + gameObject.name + "' has no sprite renderer.");
			}
		}

		var aSources = GetComponents<AudioSource>();
		audios = aSources [0];
		audios1 = aSources [1];
		audios2 = aSources [2];
		audios3 = aSources [3];
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Hammer") {
			audios.PlayOneShot (impact, 0.25f);
			health--;
			Counter.lives--;
			if (invulnPeriod > 0) {
				invulnTimer = invulnPeriod;
				gameObject.layer = 11;
			}
		} else if (other.gameObject.tag == "Square" && Counter.square) {
			audios1.PlayOneShot (coinDrop, 1);
		} else if (other.gameObject.tag == "Star" && Counter.star) {
			audios1.PlayOneShot (coinDrop, 1);
		} else if (other.gameObject.tag == "Circle" && Counter.circle) {
			audios1.PlayOneShot (coinDrop, 1);
		} else if (other.gameObject.tag == "Triangle" && Counter.triangle) {
			audios1.PlayOneShot (coinDrop, 1);
		} else if (other.gameObject.tag == "HealthPack") {
			audios2.PlayOneShot (powerUp, 0.5f);
		} else if (other.gameObject.tag == "DoubleGold") {
			audios2.PlayOneShot (powerUp, 1);
		} else if (other.gameObject.tag == "SpeedBoost") {
			audios2.PlayOneShot (powerUp, 0.5f);
		} else if (other.gameObject.tag == "Slomo") {
			audios2.PlayOneShot (powerUp, 0.5f);
		} else if (other.gameObject.tag == "HammerDB") {
			audios3.PlayOneShot (evilLaugh, 0.25f);
		} else if (other.gameObject.tag == "SpeedDB") {
			audios3.PlayOneShot (evilLaugh, 0.25f);
		} 
	}
	void Die(){
		Destroy (gameObject);
	}

	void Update(){
		frames++;

		if (frames % 10 == 0) {
			frameUpdate ();
		}
		if (invulnTimer > 0) {
			invulnTimer -= Time.deltaTime;

			if (invulnTimer <= 0) {
				gameObject.layer = correctLayer;
				//if (spriteRend != null) {
				//	spriteRend.enabled = true;
				//}
			} //else {
				//if (spriteRend != null) {
				//	spriteRend.enabled = !spriteRend.enabled;
				//}
			//}
					
		}

		if (health <= 0) {
			Die ();
			if (Counter.coins > GameCtrl.control.mostCoins) {
				GameCtrl.control.mostCoins = Counter.coins;
			}
			GameCtrl.control.savedCoins += Counter.coins;
			health = 3;
			GameCtrl.control.Save();
			LoadScene ("GameOver");

		}
	}

	void frameUpdate(){
		if (invulnTimer <= 0) {
			gameObject.layer = correctLayer;
			if (spriteRend != null) {
				spriteRend.enabled = true;
			}
		} else {
			if (spriteRend != null) {
				spriteRend.enabled = !spriteRend.enabled;
			}
		}
		
	}
	public void LoadScene(string sceneName){
		SceneManager.LoadScene(sceneName);
	}
		
}
