using UnityEngine;
using System.Collections;

public class PlayerSpawn : MonoBehaviour {
	public GameObject playerPrefab;
	GameObject playerInstance;
	float respawnTimer = 1;

	// Use this for initialization
	void Start () {
		SpawnPlayer();
	
	}

	void SpawnPlayer(){
		respawnTimer = 1;
		playerInstance = (GameObject)Instantiate (playerPrefab, transform.position, Quaternion.identity);
	}
	// Update is called once per frame
	void Update () {
		if (playerInstance == null && Counter.lives > 0) {
			respawnTimer -= Time.deltaTime;
			if (respawnTimer <= 0) {
				SpawnPlayer ();
			}
		}
	}
	}
