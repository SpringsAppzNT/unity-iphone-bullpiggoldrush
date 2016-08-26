using UnityEngine;
using System.Collections;

public class SaucerCtrl : MonoBehaviour {

	public void pressButton (string buttonName){
		
		if (buttonName == "redSaucer" && GameCtrl.control.RSPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.RSPrice;
			GameCtrl.control.RSPrice = 0;
			GameCtrl.control.oSaucer = false;
			GameCtrl.control.redSaucer = true;
			GameCtrl.control.blueSaucer = false;
			GameCtrl.control.yellowSaucer = false;
			GameCtrl.control.pinkSaucer = false;
			GameCtrl.control.purpleSaucer = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "blueSaucer" && GameCtrl.control.BSPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.BSPrice;
			GameCtrl.control.BSPrice = 0;
			GameCtrl.control.oSaucer = false;
			GameCtrl.control.redSaucer = false;
			GameCtrl.control.blueSaucer = true;
			GameCtrl.control.yellowSaucer = false;
			GameCtrl.control.pinkSaucer = false;
			GameCtrl.control.purpleSaucer = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "yellowSaucer" && GameCtrl.control.YSPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.YSPrice;
			GameCtrl.control.YSPrice = 0;
			GameCtrl.control.oSaucer = false;
			GameCtrl.control.redSaucer = false;
			GameCtrl.control.blueSaucer = false;
			GameCtrl.control.yellowSaucer = true;
			GameCtrl.control.pinkSaucer = false;
			GameCtrl.control.purpleSaucer = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "pinkSaucer" && GameCtrl.control.PSPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.PSPrice;
			GameCtrl.control.PSPrice = 0;
			GameCtrl.control.oSaucer = false;
			GameCtrl.control.redSaucer = false;
			GameCtrl.control.blueSaucer = false;
			GameCtrl.control.yellowSaucer = false;
			GameCtrl.control.pinkSaucer = true;
			GameCtrl.control.purpleSaucer = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "purpleSaucer" && GameCtrl.control.PrSPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.PrSPrice;
			GameCtrl.control.PrSPrice = 0;
			GameCtrl.control.oSaucer = false;
			GameCtrl.control.redSaucer = false;
			GameCtrl.control.blueSaucer = false;
			GameCtrl.control.yellowSaucer = false;
			GameCtrl.control.pinkSaucer = false;
			GameCtrl.control.purpleSaucer = true;
			GameCtrl.control.Save ();
		} else if (buttonName == "oSaucer") {
			GameCtrl.control.oSaucer = true;
			GameCtrl.control.redSaucer = false;
			GameCtrl.control.blueSaucer = false;
			GameCtrl.control.yellowSaucer = false;
			GameCtrl.control.pinkSaucer = false;
			GameCtrl.control.purpleSaucer = false;
			GameCtrl.control.Save ();
		}
		
	}

	void Update(){


	}
}

