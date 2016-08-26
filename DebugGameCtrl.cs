using UnityEngine;
using System.Collections;

public class DebugGameCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("PigPrice is " + GameCtrl.control.pigPrice);
		print ("CowPrice is " + GameCtrl.control.cowPrice);
		print ("BunnyPrice is " + GameCtrl.control.bunnyPrice);
		print ("GoldPrice is " + GameCtrl.control.goldPrice);
		print ("DevilPrice is " + GameCtrl.control.devilPrice);

		print (GameCtrl.control.bullPig);
		print (GameCtrl.control.pigPig);
		print (GameCtrl.control.cowPig);
		print (GameCtrl.control.bunnyPig);
		print (GameCtrl.control.goldPig);
		print (GameCtrl.control.devilPig);

		GameCtrl.control.pigPrice = 0;
		GameCtrl.control.cowPrice = 0;
		GameCtrl.control.bunnyPrice = 0;
		GameCtrl.control.goldPrice = 0;
		GameCtrl.control.devilPrice = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
