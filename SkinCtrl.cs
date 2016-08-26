using UnityEngine;
using System.Collections;

public class SkinCtrl : MonoBehaviour {

	public void pressButton (string buttonName){
		
		if (buttonName == "pigPig" && GameCtrl.control.pigPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.pigPrice;
			GameCtrl.control.pigPrice = 0;
			GameCtrl.control.bullPig = false;
			GameCtrl.control.pigPig = true;
			GameCtrl.control.cowPig = false;
			GameCtrl.control.bunnyPig = false;
			GameCtrl.control.goldPig = false;
			GameCtrl.control.devilPig = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "cowPig" && GameCtrl.control.cowPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.cowPrice;
			GameCtrl.control.cowPrice = 0;
			GameCtrl.control.bullPig = false;
			GameCtrl.control.pigPig = false;
			GameCtrl.control.cowPig = true;
			GameCtrl.control.bunnyPig = false;
			GameCtrl.control.goldPig = false;
			GameCtrl.control.devilPig = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "bunnyPig" && GameCtrl.control.bunnyPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.bunnyPrice;
			GameCtrl.control.bunnyPrice = 0;
			GameCtrl.control.bullPig = false;
			GameCtrl.control.pigPig = false;
			GameCtrl.control.cowPig = false;
			GameCtrl.control.bunnyPig = true;
			GameCtrl.control.goldPig = false;
			GameCtrl.control.devilPig = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "goldPig" && GameCtrl.control.goldPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.goldPrice;
			GameCtrl.control.goldPrice = 0;
			GameCtrl.control.bullPig = false;
			GameCtrl.control.pigPig = false;
			GameCtrl.control.cowPig = false;
			GameCtrl.control.bunnyPig = false;
			GameCtrl.control.goldPig = true;
			GameCtrl.control.devilPig = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "devilPig" && GameCtrl.control.devilPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.devilPrice;
			GameCtrl.control.devilPrice = 0;
			GameCtrl.control.bullPig = false;
			GameCtrl.control.pigPig = false;
			GameCtrl.control.cowPig = false;
			GameCtrl.control.bunnyPig = false;
			GameCtrl.control.goldPig = false;
			GameCtrl.control.devilPig = true;
			GameCtrl.control.Save ();
		} else if (buttonName == "original") {
			GameCtrl.control.bullPig = true;
			GameCtrl.control.pigPig = false;
			GameCtrl.control.cowPig = false;
			GameCtrl.control.bunnyPig = false;
			GameCtrl.control.goldPig = false;
			GameCtrl.control.devilPig = false;
			GameCtrl.control.Save ();
		}
		
	}

	void Update(){


	}
}

