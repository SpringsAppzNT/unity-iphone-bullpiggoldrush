using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoinSpawn : MonoBehaviour {
	List<GameObject> prefabList = new List<GameObject>();
	public GameObject coinPrefab;
	public GameObject cointrianglePrefab;
	public GameObject coinsquarePrefab;
	public GameObject coinstarPrefab;

	public static bool goldRush = false;


	float coinRate = 5;
	float nextCoin = 1;
	float coinBoundaryRadius = 0.6f;

	void Start(){
		prefabList.Add (coinPrefab);
		prefabList.Add (cointrianglePrefab);
		prefabList.Add (coinsquarePrefab);
		prefabList.Add (coinstarPrefab);
		
	}
	// Update is called once per frame
	void Update () {
		nextCoin -= Time.deltaTime;

		if (nextCoin <= 0) {
			nextCoin = coinRate;
			coinRate *= 0.9f;

			if (coinRate < 2) {
				coinRate = 2;
			}

			if (goldRush) {
				coinRate = 0.5f;
			}

			Vector3 offset;

			offset.z = 0;

			offset.y = 0;

			float screenRatio = (float) Screen.width / (float) Screen.height;
			float widthOrtho = Camera.main.orthographicSize * screenRatio;

			offset.x = Random.Range(-widthOrtho + coinBoundaryRadius, widthOrtho - coinBoundaryRadius);

			//offset = offset.normalized;

			int prefabIndex = UnityEngine.Random.Range (0, 4);

			Instantiate(prefabList[prefabIndex], transform.position + offset, Quaternion.identity);


		}
	}
}
