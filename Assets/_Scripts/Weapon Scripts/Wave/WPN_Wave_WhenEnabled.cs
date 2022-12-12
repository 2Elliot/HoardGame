using System;
using UnityEngine;

public class WPN_Wave_WhenEnabled : MonoBehaviour
{
	private PlayerStats playerStats;

	private float timer;

	private Vector2 scale = new Vector2 (1, 1);

	private void Awake() {
		playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
	}

	private void Update() {

		timer += Time.deltaTime;

		scale[0] += timer * playerStats.waveSpeed;
		scale[1] += timer * playerStats.waveSpeed;

		gameObject.transform.localScale = scale;

		if (gameObject.transform.localScale.y >= 45f) {
			gameObject.transform.localScale = scale;
			timer = 0;
			scale[0] = 0;
			scale[1] = 0;
			gameObject.transform.localScale = scale;
			gameObject.SetActive(false);

		}

	}

}
