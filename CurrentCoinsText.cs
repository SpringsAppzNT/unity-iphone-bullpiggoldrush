using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CurrentCoinsText : MonoBehaviour {
	Text text;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		text.text = "Coins: " + Counter.coins;
	}
}
