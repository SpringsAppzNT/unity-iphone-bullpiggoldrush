using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MostCoinsText : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		text.text = "High Score: " + GameCtrl.control.mostCoins;
	}
}
