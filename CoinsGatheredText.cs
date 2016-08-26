using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinsGatheredText : MonoBehaviour {
	Text text;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		text.text = "Coins Collected: " + Counter.coins;
	}
}
