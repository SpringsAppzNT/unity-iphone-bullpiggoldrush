using UnityEngine;
using System.Collections;

public class HammerSpawn : MonoBehaviour {

	public GameObject hammerPrefab;
	public GameObject bonePrefab;
	public GameObject fishPrefab;
	public GameObject inflatablePrefab;
	public GameObject pizzaPrefab;

	float hammerRate = 10;
	float nextHammer= 2;
	float hammerBoundaryRadius = 0.6f;
	// Update is called once per frame
	void Update () {
		nextHammer -= Time.deltaTime;

		if (nextHammer <= 0) {
			nextHammer = hammerRate;
			hammerRate *= 0.9f;

			if (hammerRate < 1) {
				hammerRate = 1;
			}

			Vector3 offset;

			offset.z = 0;

			offset.y = 0;

			float screenRatio = (float) Screen.width / (float) Screen.height;
			float widthOrtho = Camera.main.orthographicSize * screenRatio;

			offset.x = Random.Range(-widthOrtho + hammerBoundaryRadius, widthOrtho - hammerBoundaryRadius);

			//offset = offset.normalized;


			float randomNumber = Random.Range (0, 5);
			if (randomNumber == 0) {
				Instantiate(hammerPrefab, transform.position + offset, Quaternion.identity);
			} else if (randomNumber == 1) {
				Instantiate(bonePrefab, transform.position + offset, Quaternion.identity);
			} else if (randomNumber == 2) {
				Instantiate(fishPrefab, transform.position + offset, Quaternion.identity);
			} else if (randomNumber == 3) {
				Instantiate(inflatablePrefab, transform.position + offset, Quaternion.identity);
			} else if (randomNumber == 4) {
				Instantiate(pizzaPrefab, transform.position + offset, Quaternion.identity);
			}
		}
	}
}
