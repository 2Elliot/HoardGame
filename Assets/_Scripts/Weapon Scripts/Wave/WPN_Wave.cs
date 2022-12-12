using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPN_Wave : MonoBehaviour
{
	PlayerStats playerStats;

	[SerializeField] private GameObject waveObj;

	private float timer;

	private void Awake() {
		playerStats = GameObject.FindWithTag("GameController").GetComponent<PlayerStats>();
	}

	private void Update() {
		timer += Time.deltaTime;

		if (timer > playerStats.waveCooldown) {
			waveObj.SetActive(true);
			timer = 0;
		}
	}
}
