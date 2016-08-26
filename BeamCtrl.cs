using UnityEngine;
using System.Collections;

public class BeamCtrl : MonoBehaviour {

	public void pressButton (string buttonName){
		
		if (buttonName == "redBeam" && GameCtrl.control.RBPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.RBPrice;
			GameCtrl.control.RBPrice = 0;
			GameCtrl.control.oBeam = false;
			GameCtrl.control.redBeam = true;
			GameCtrl.control.blueBeam = false;
			GameCtrl.control.yellowBeam = false;
			GameCtrl.control.pinkBeam = false;
			GameCtrl.control.purpleBeam = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "blueBeam" && GameCtrl.control.BBPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.BBPrice;
			GameCtrl.control.BBPrice = 0;
			GameCtrl.control.oBeam = false;
			GameCtrl.control.redBeam = false;
			GameCtrl.control.blueBeam = true;
			GameCtrl.control.yellowBeam = false;
			GameCtrl.control.pinkBeam = false;
			GameCtrl.control.purpleBeam = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "yellowBeam" && GameCtrl.control.YBPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.YBPrice;
			GameCtrl.control.YBPrice = 0;
			GameCtrl.control.oBeam = false;
			GameCtrl.control.redBeam = false;
			GameCtrl.control.blueBeam = false;
			GameCtrl.control.yellowBeam = true;
			GameCtrl.control.pinkBeam = false;
			GameCtrl.control.purpleBeam = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "pinkBeam" && GameCtrl.control.PBPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.PBPrice;
			GameCtrl.control.PBPrice = 0;
			GameCtrl.control.oBeam = false;
			GameCtrl.control.redBeam = false;
			GameCtrl.control.blueBeam = false;
			GameCtrl.control.yellowBeam = false;
			GameCtrl.control.pinkBeam = true;
			GameCtrl.control.purpleBeam = false;
			GameCtrl.control.Save ();
		} else if (buttonName == "purpleBeam" && GameCtrl.control.PrBPrice <= GameCtrl.control.savedCoins) {
			GameCtrl.control.savedCoins = GameCtrl.control.savedCoins - GameCtrl.control.PrBPrice;
			GameCtrl.control.PrBPrice = 0;
			GameCtrl.control.oBeam = false;
			GameCtrl.control.redBeam = false;
			GameCtrl.control.blueBeam = false;
			GameCtrl.control.yellowBeam = false;
			GameCtrl.control.pinkBeam = false;
			GameCtrl.control.purpleBeam = true;
			GameCtrl.control.Save ();
		} else if (buttonName == "oBeam") {
			GameCtrl.control.oBeam = true;
			GameCtrl.control.redBeam = false;
			GameCtrl.control.blueBeam = false;
			GameCtrl.control.yellowBeam = false;
			GameCtrl.control.pinkBeam = false;
			GameCtrl.control.purpleBeam = false;
			GameCtrl.control.Save ();
		}
		
	}

	void Update(){


	}
}

