using UnityEngine;
using System.Collections;

public class BuffsSpawn : MonoBehaviour {

	public GameObject healthPackPrefab;
	public GameObject speedBoostPrefab;
	public GameObject speedDBPrefab;
	public GameObject hammerDBPrefab;
	public GameObject slomoPrefab;
	public GameObject doubleGoldPrefab;


	float healthRate = 80;
	float healthNext= 30;

	float speedRate = 40;
	float speedNext = 40;

	float speedDBRate = 50;
	float speedDBNext = 50;

	float hammerDBRate = 60;
	float hammerDBNext = 60;

	float slomoRate = 70;
	float slomoNext = 70;

	float doubleGoldRate = 80;
	float doubleGoldNext = 20;

	float BoundaryRadius = 0.6f;
	// Update is called once per frame
	void Update () {
		if (Counter.lives < 3) {

			healthNext -= Time.deltaTime;

			if (healthNext <= 0) {
				healthNext = healthRate;
				healthRate *= 1.1f;

				//if (healthRate < 2) {
				//	healthRate = 2;
				//}

				Vector3 offset;
					
				offset.z = 0;
					
				offset.y = 0;

				float screenRatio = (float)Screen.width / (float)Screen.height;
				float widthOrtho = Camera.main.orthographicSize * screenRatio;
					
				offset.x = Random.Range (-widthOrtho + BoundaryRadius, widthOrtho - BoundaryRadius);

				Instantiate (healthPackPrefab, transform.position + offset, Quaternion.identity);

			}
		}
		speedNext -= Time.deltaTime;

		if (speedNext <= 0) {
			speedNext = speedRate;
			speedRate *= 1.1f;

			//if (healthRate < 2) {
			//	healthRate = 2;
			//}

			Vector3 offset;

			offset.z = 0;

			offset.y = 0;

			float screenRatio = (float)Screen.width / (float)Screen.height;
			float widthOrtho = Camera.main.orthographicSize * screenRatio;

			offset.x = Random.Range (-widthOrtho + BoundaryRadius, widthOrtho - BoundaryRadius);

			Instantiate (speedBoostPrefab, transform.position + offset, Quaternion.identity);

		}
		speedDBNext -= Time.deltaTime;

		if (speedDBNext <= 0) {
			speedDBNext = speedDBRate;
			speedDBRate *= 0.9f;

			if (speedDBRate < 2) {
				speedDBRate = 2;
			}

			Vector3 offset;

			offset.z = 0;

			offset.y = 0;

			float screenRatio = (float)Screen.width / (float)Screen.height;
			float widthOrtho = Camera.main.orthographicSize * screenRatio;

			offset.x = Random.Range (-widthOrtho + BoundaryRadius, widthOrtho - BoundaryRadius);

			Instantiate (speedDBPrefab, transform.position + offset, Quaternion.identity);

		}
		hammerDBNext -= Time.deltaTime;

		if (hammerDBNext <= 0) {
			hammerDBNext = hammerDBRate;
			hammerDBRate *= 0.9f;

			if (hammerDBRate < 2) {
				hammerDBRate = 2;
			}

			Vector3 offset;

			offset.z = 0;

			offset.y = 0;

			float screenRatio = (float)Screen.width / (float)Screen.height;
			float widthOrtho = Camera.main.orthographicSize * screenRatio;

			offset.x = Random.Range (-widthOrtho + BoundaryRadius, widthOrtho - BoundaryRadius);

			Instantiate (hammerDBPrefab, transform.position + offset, Quaternion.identity);

		}

		slomoNext -= Time.deltaTime;

		if (slomoNext <= 0) {
			slomoNext = slomoRate;
			slomoRate *= 1.1f;

			if (slomoRate < 2) {
				slomoRate = 2;
			}

			Vector3 offset;

			offset.z = 0;

			offset.y = 0;

			float screenRatio = (float)Screen.width / (float)Screen.height;
			float widthOrtho = Camera.main.orthographicSize * screenRatio;

			offset.x = Random.Range (-widthOrtho + BoundaryRadius, widthOrtho - BoundaryRadius);

			Instantiate (slomoPrefab, transform.position + offset, Quaternion.identity);

		}

		doubleGoldNext -= Time.deltaTime;

		if (doubleGoldNext <= 0) {
			doubleGoldNext = doubleGoldRate;
			doubleGoldRate *= 1.1f;

			if (doubleGoldRate < 2) {
				doubleGoldRate = 2;
			}

			Vector3 offset;

			offset.z = 0;

			offset.y = 0;

			float screenRatio = (float)Screen.width / (float)Screen.height;
			float widthOrtho = Camera.main.orthographicSize * screenRatio;

			offset.x = Random.Range (-widthOrtho + BoundaryRadius, widthOrtho - BoundaryRadius);

			Instantiate (doubleGoldPrefab, transform.position + offset, Quaternion.identity);

		}
	}
}