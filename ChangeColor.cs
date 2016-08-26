using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ChangeColor : MonoBehaviour {
	public Sprite original;
	public Sprite newSprite;
	private Button button;

	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.tag == "Circle") {
			if (Counter.circle) {
				button.image.sprite = newSprite;
			} else {
				button.image.sprite = original;
			}
		} else if (gameObject.tag == "Triangle") {
			if (Counter.triangle) {
				button.image.sprite = newSprite;
			} else {
				button.image.sprite = original;
			}
		} else if (gameObject.tag == "Square") {
			if (Counter.square) {
				button.image.sprite = newSprite;
			} else {
				button.image.sprite = original;
			}
		} else if (gameObject.tag == "Star") {
			if (Counter.star) {
				button.image.sprite = newSprite;
			} else {
				button.image.sprite = original;
			}
		} else if (gameObject.tag == "revert") {
			if (GameCtrl.control.bullPig) {
				button.image.sprite = original;
			} else {
				button.image.sprite = newSprite;
			}
		} else if (gameObject.tag == "SpeedBoost") {
			if (BuffsHandler.speedTimer > 0) {
				button.image.sprite = newSprite;
			} else {
				button.image.sprite = original;
			}
		} else if (gameObject.tag == "SpeedDB") {
			if (BuffsHandler.speedDBTimer > 0) {
				button.image.sprite = newSprite;
			} else {
				button.image.sprite = original;
			}
		} else if (gameObject.tag == "oSaucer") {
			if (GameCtrl.control.oSaucer) {
				button.image.sprite = original;
			} else {
				button.image.sprite = newSprite;
			}
		} else if (gameObject.tag == "oBeam") {
			if (GameCtrl.control.oBeam) {
				button.image.sprite = original;
			} else {
				button.image.sprite = newSprite;
			}
		}
	}
		
}
