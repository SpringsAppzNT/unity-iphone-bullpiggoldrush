using UnityEngine;
using System.Collections;

public class CollectedHandler : MonoBehaviour {
	int health = 1;
	public GameObject coinPlusOnePrefab;
	public GameObject coinPlusTwoPrefab;

	void OnTriggerEnter2D(Collider2D player){
		if (player.gameObject.tag == "Player") {
			if (this.gameObject.tag == "Circle" && Counter.circle) {
				health--;
			} else if (this.gameObject.tag == "Triangle" && Counter.triangle) {
				health--;
			} else if (this.gameObject.tag == "Square" && Counter.square) {
				health--;
			} else if (this.gameObject.tag == "Star" && Counter.star) {
				health--;
			} 

			if (health <= 0) {
				Collected ();
			}
		}
	}
	void Collected(){
		if (Counter.doubleGold) {
			Counter.coins += 2;
			Vector3 pos = transform.position;
			Instantiate(coinPlusTwoPrefab, pos, Quaternion.identity);
		} else {
			Counter.coins++;
			Vector3 pos = transform.position;
			Instantiate(coinPlusOnePrefab, pos, Quaternion.identity);
		}
		Destroy (gameObject);
	}
}
