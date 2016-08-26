using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class RandomBackground : MonoBehaviour {
	public Sprite background1;
	public Sprite background2;
	public Sprite background3;
	public Sprite background4;

	// Use this for initialization
	void Start () {
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		float random = Random.Range (0, 4);
		if (random == 0) {
			sr.sprite = background1;
			
		} else if (random == 1) {
			sr.sprite = background2;
		} else if (random == 2) {
			sr.sprite = background3;
		} else if (random == 3) {
			sr.sprite = background4;
		}
		
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
