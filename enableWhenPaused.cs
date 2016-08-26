using UnityEngine;
using System.Collections;

public class enableWhenPaused : MonoBehaviour {
	public GameObject thisOne;
	// Use this for initialization
	void Start () {
		thisOne.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Counter.pause) {
			thisOne.SetActive (true);
		} else {
			thisOne.SetActive (false);
		}
	
	}
}
