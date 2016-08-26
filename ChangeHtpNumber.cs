using UnityEngine;
using System.Collections;

public class ChangeHtpNumber : MonoBehaviour {

	public void pressButton(string buttonName){
		print ("Starting pressButton Function");
		if (buttonName == "back") {
			ChangeHtp.sequence = ChangeHtp.sequence - 1;
		} else if (buttonName == "forward") {
			ChangeHtp.sequence = ChangeHtp.sequence + 1;
		}
	}
}
