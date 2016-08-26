using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour {
	void Start(){
		GameCtrl.control.Load();
	}
	
	public void LoadScene(string sceneName){
		SceneManager.LoadScene(sceneName);
	}
	public void pressButton(string buttonName){
		print ("Starting pressButton Function");
		if (buttonName == "back") {
			ChangeHtp.sequence = ChangeHtp.sequence - 1;
		} else if (buttonName == "forward") {
			ChangeHtp.sequence = ChangeHtp.sequence + 1;
		}
	}
}
