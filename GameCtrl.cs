using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameCtrl : MonoBehaviour {
	
	public static GameCtrl control;

	public float savedCoins;
	public float mostCoins;

	public float pigPrice = 0;
	public float cowPrice = 0;
	public float bunnyPrice = 0;
	public float goldPrice = 0;
	public float devilPrice = 0;

	public float OSPrice = 0;
	public float RSPrice = 0;
	public float BSPrice = 0;
	public float YSPrice = 0;
	public float PSPrice = 0;
	public float PrSPrice = 0;

	public float OBPrice = 0;
	public float RBPrice = 0;
	public float BBPrice = 0;
	public float YBPrice = 0;
	public float PBPrice = 0;
	public float PrBPrice = 0;

	public bool bullPig = true;
	public bool pigPig = false;
	public bool cowPig = false;
	public bool bunnyPig = false;
	public bool goldPig = false;
	public bool devilPig = false;

	public bool oSaucer = true;
	public bool redSaucer = false;
	public bool blueSaucer = false;
	public bool yellowSaucer = false;
	public bool pinkSaucer = false;
	public bool purpleSaucer = false;

	public bool oBeam = true;
	public bool redBeam = false;
	public bool blueBeam = false;
	public bool yellowBeam = false;
	public bool pinkBeam = false;
	public bool purpleBeam = false;

	// Use this for initialization
	void Awake () {
		if (control == null) {
			
			DontDestroyOnLoad (gameObject);
			control = this;

		} else if(control != this){
			
			Destroy (gameObject);
		}
	}

	public void Save(){

		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

		PlayerData data = new PlayerData ();
		data.savedCoins = savedCoins;
		data.mostCoins = mostCoins;
		data.pigPrice = pigPrice;
		data.cowPrice = cowPrice;
		data.bunnyPrice = bunnyPrice;
		data.goldPrice = goldPrice;
		data.devilPrice = devilPrice;
		data.bullPig = bullPig;
		data.pigPig = pigPig;
		data.cowPig = cowPig;
		data.bunnyPig = bunnyPig;
		data.goldPig = goldPig;
		data.devilPig = devilPig;
		data.oSaucer = oSaucer;
		data.redSaucer = redSaucer;
		data.blueSaucer = blueSaucer;
		data.yellowSaucer = yellowSaucer;
		data.pinkSaucer = pinkSaucer;
		data.purpleSaucer = purpleSaucer;
		data.oBeam = oBeam;
		data.redBeam = redBeam;
		data.blueBeam = blueBeam;
		data.yellowBeam = yellowBeam;
		data.pinkBeam = pinkBeam;
		data.purpleBeam = purpleBeam;
		data.OSPrice = OSPrice;
		data.RSPrice = RSPrice;
		data.BSPrice = BSPrice;
		data.YSPrice = YSPrice;
		data.PSPrice = PSPrice;
		data.PrSPrice = PrSPrice;
		data.OBPrice = OBPrice;
		data.RBPrice = RBPrice;
		data.BBPrice = BBPrice;
		data.YBPrice = YBPrice;
		data.PBPrice = PBPrice;
		data.PrBPrice = PrBPrice;
	

		bf.Serialize(file, data);
		file.Close();
	}

	public void Load(){
		if (File.Exists(Application.persistentDataPath + "/playerInfo.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize (file);
			file.Close();

			savedCoins = data.savedCoins;
			mostCoins = data.mostCoins;
			pigPrice = data.pigPrice;
			cowPrice = data.cowPrice;
			bunnyPrice = data.bunnyPrice;
			goldPrice = data.goldPrice;
			devilPrice = data.devilPrice;
			bullPig = data.bullPig;
			pigPig = data.pigPig;
			cowPig = data.cowPig;
			bunnyPig = data.bunnyPig;
			goldPig = data.goldPig;
			devilPig = data.devilPig;
			oSaucer = data.oSaucer;
			redSaucer = data.redSaucer;
			blueSaucer = data.blueSaucer;
			yellowSaucer = data.yellowSaucer;
			pinkSaucer = data.pinkSaucer;
			purpleSaucer = data.purpleSaucer;
			oBeam = data.oBeam;
			redBeam = data.redBeam;
			blueBeam = data.blueBeam;
			yellowBeam = data.yellowBeam;
			pinkBeam = data.pinkBeam;
			purpleBeam = data.purpleBeam;
			OSPrice = data.OSPrice;
			RSPrice = data.RSPrice;
			BSPrice = data.BSPrice;
			YSPrice = data.YSPrice;
			PSPrice = data.PSPrice;
			PrSPrice = data.PrSPrice;
			OBPrice = data.OBPrice;
			RBPrice = data.RBPrice;
			BBPrice = data.BBPrice;
			YBPrice = data.YBPrice;
			PBPrice = data.PBPrice;
			PrBPrice = data.PrBPrice;

		}
	}
}

[Serializable]
class PlayerData{
	
	public float savedCoins;
	public float mostCoins;

	public float pigPrice = 0;
	public float cowPrice = 0;
	public float bunnyPrice = 0;
	public float goldPrice = 0;
	public float devilPrice = 0;

	public float OSPrice = 0;
	public float RSPrice = 0;
	public float BSPrice = 0;
	public float YSPrice = 0;
	public float PSPrice = 0;
	public float PrSPrice = 0;

	public float OBPrice = 0;
	public float RBPrice = 0;
	public float BBPrice = 0;
	public float YBPrice = 0;
	public float PBPrice = 0;
	public float PrBPrice = 0;

	public bool bullPig = true;
	public bool pigPig = false;
	public bool cowPig = false;
	public bool bunnyPig = false;
	public bool goldPig = false;
	public bool devilPig = false;

	public bool oSaucer = true;
	public bool redSaucer = false;
	public bool blueSaucer = false;
	public bool yellowSaucer = false;
	public bool pinkSaucer = false;
	public bool purpleSaucer = false;

	public bool oBeam = true;
	public bool redBeam = false;
	public bool blueBeam = false;
	public bool yellowBeam = false;
	public bool pinkBeam = false;
	public bool purpleBeam = false;
}
