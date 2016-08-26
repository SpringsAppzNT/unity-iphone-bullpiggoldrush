using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainCtrl : MonoBehaviour {
	public GameObject continueButton;
	public GameObject menuButton;
	public GameObject areYouSure;
	public GameObject yes;
	public GameObject no;

	public void pressButton (string buttonName){
		if (buttonName == "circle" && !Counter.pause) {
			Counter.circle = true;
			Counter.triangle = false;
			Counter.square = false;
			Counter.star = false;
		} else if (buttonName == "triangle" && !Counter.pause) {
			Counter.circle = false;
			Counter.triangle = true;
			Counter.square = false;
			Counter.star = false;
		} else if (buttonName == "square" && !Counter.pause) {
			Counter.circle = false;
			Counter.triangle = false;
			Counter.square = true;
			Counter.star = false;
		} else if (buttonName == "star" && !Counter.pause) {
			Counter.circle = false;
			Counter.triangle = false;
			Counter.square = false;
			Counter.star = true;
		} else if (buttonName == "pause" || buttonName == "continue") {
			if (Counter.pause) {
				Time.timeScale = 1;
			} else {
				Time.timeScale = 0;
			}
			Counter.pause = !Counter.pause;
		} else if (buttonName == "menu") {
			Counter.areYouSure = true;
		} else if (buttonName == "no") {
			Counter.areYouSure = false;
		}
	}

	void Update(){
		if (Counter.pause && !Counter.areYouSure) {
			continueButton.SetActive (true);
			menuButton.SetActive (true);
			areYouSure.SetActive (false);
			yes.SetActive (false);
			no.SetActive (false);
		} else if (Counter.pause && Counter.areYouSure) {
			continueButton.SetActive (false);
			menuButton.SetActive (false);
			areYouSure.SetActive (true);
			yes.SetActive (true);
			no.SetActive (true);
		} else {
			continueButton.SetActive (false);
			menuButton.SetActive (false);
			areYouSure.SetActive (false);
			yes.SetActive (false);
			no.SetActive (false);
		}
		
	}
}
