using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour {
	public static int coins = 0;
	public static int lives = 3;

	public static bool circle = true;
	public static bool triangle = false;
	public static bool square = false; 
	public static bool star = false;

	public static bool pause = false;
	public static bool areYouSure = false;
	public static bool slomo = false;
	public static bool doubleGold = false;

	public static bool bullPig = true;
	public static bool pigPig = false;
	public static bool cowPig = false;
	public static bool bunnyPig = false;
	public static bool goldPig = false;
	public static bool devilPig = false; 

	public static float goldRushTimer;
	public GameObject goldRushText;

	// Use this for initialization
	void Start () {
		lives = 3;
		coins = 0;
		circle = true;
		triangle = false;
		square = false;
		star = false; 
		pause = false;
		areYouSure = false;
		slomo = false;
		doubleGold = false;
		Time.timeScale = 1;
		DamageHandler.health = 3;
		BuffsHandler.speedTimer = 0;
		BuffsHandler.speedDBTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if  (coins % 50 == 0 && coins != 0 && !CoinSpawn.goldRush){
			goldRush ();
		}
		goldRushTimer -= Time.deltaTime;

		if (goldRushTimer < 0) {
			CoinSpawn.goldRush = false;
		}
	
	}

	void goldRush(){
		CoinSpawn.goldRush = true;
		Vector3 pos = new Vector3 (0, 0);
		Instantiate (goldRushText, pos, Quaternion.identity);
		goldRushTimer = 10;

	}
	//void OnGUI(){
		//GUIStyle myStyle = new GUIStyle();
		//myStyle.font = (Font)Resources.Load("Fonts/Showcard Gothic");
		//GUI.contentColor = Color.black;
		//GUI.Label (new Rect (Screen.width - 100, 0, 100, 50), "Coins: " + coins, myStyle);
		//if (lives > 0) {
		//	GUI.Label (new Rect (0, 0, 100, 50), "Lives: " + lives, myStyle);
		//} else {
		//	//GUI.Label (new Rect (0, 0, 100, 50), "Lives: 0", myStyle);
		//	//GUI.Label (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "GAME OVER", myStyle);
		//	lives = 3;
		//	coins = 0;
		//}
	//}
}
