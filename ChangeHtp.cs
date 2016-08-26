using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(SpriteRenderer))]
public class ChangeHtp : MonoBehaviour {
	public Sprite htp1;
	public Sprite htp2;
	public Sprite htp3;
	public Sprite htp4;

	public static float sequence;

	// Use this for initialization
	void Start () {
		sequence = 0;
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		sr.sprite = htp1;
	}
	
	// Update is called once per frame
	void Update () {
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		if (sequence == -1 || sequence == 4) {
			SceneManager.LoadScene ("Menu");
		} else if (sequence == 0) {
			sr.sprite = htp1;
		} else if (sequence == 1) {
			sr.sprite = htp2;
		} else if (sequence == 2) {
			sr.sprite = htp3;
		} else if (sequence == 3) {
			sr.sprite = htp4;
		}
	
	}

}
