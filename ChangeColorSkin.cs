using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ChangeColorSkin : MonoBehaviour {
	public Sprite price;
	public Sprite owned;
	public Sprite equipped;
	private Button button;

	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if (gameObject.tag == "pigPig") {
			if (GameCtrl.control.pigPig) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.pigPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "cowPig") {
			if (GameCtrl.control.cowPig) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.cowPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "bunnyPig") {
			if (GameCtrl.control.bunnyPig) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.bunnyPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "goldPig") {
			if (GameCtrl.control.goldPig) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.goldPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "devilPig") {
			if (GameCtrl.control.devilPig) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.devilPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "redSaucer") {
			if (GameCtrl.control.redSaucer) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.RSPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "blueSaucer") {
			if (GameCtrl.control.blueSaucer) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.BSPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "yellowSaucer") {
			if (GameCtrl.control.yellowSaucer) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.YSPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "pinkSaucer") {
			if (GameCtrl.control.pinkSaucer) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.PSPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "purpleSaucer") {
			if (GameCtrl.control.purpleSaucer) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.PrSPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "redBeam") {
			if (GameCtrl.control.redBeam) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.RBPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "blueBeam") {
			if (GameCtrl.control.blueBeam) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.BBPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "yellowBeam") {
			if (GameCtrl.control.yellowBeam) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.YBPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "pinkBeam") {
			if (GameCtrl.control.pinkBeam) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.PBPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		} else if (gameObject.tag == "purpleBeam") {
			if (GameCtrl.control.purpleBeam) {
				button.image.sprite = equipped;
			} else {
				if (GameCtrl.control.PrBPrice == 0) {
					button.image.sprite = owned;
				} else {
					button.image.sprite = price;
				}
			}
		}
	}
		
}
