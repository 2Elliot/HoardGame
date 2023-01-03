using System;
using UnityEngine;
using Stats;

public class WPN_Wave_WhenEnabled : MonoBehaviour
{
	private float timer;

	private Vector2 scale = new Vector2 (1, 1);

	private void Update() {

		timer += Time.deltaTime;

		scale[0] += timer * WaveStats.speed;
		scale[1] += timer * WaveStats.speed;

		gameObject.transform.localScale = scale;

		if (gameObject.transform.localScale.y >= 50f) {
			gameObject.transform.localScale = scale;
			timer = 0;
			scale[0] = 0;
			scale[1] = 0;
			gameObject.transform.localScale = scale;
			gameObject.SetActive(false);

		}

		transform.Rotate(new Vector3(0, 0, -1), 1f);
	}

}
