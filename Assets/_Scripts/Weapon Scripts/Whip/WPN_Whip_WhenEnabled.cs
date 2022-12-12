using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPN_Whip_WhenEnabled : MonoBehaviour
{
	private float timer = 0;
	private bool isEnabled;

	private PlayerStats playerStats;

	private void Awake() {
		playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
	}

	private void OnEnable() {
		isEnabled = true;
	}

	private void Update() {
		if (isEnabled) {

			timer += Time.deltaTime;

			if (timer > playerStats.whipSpeed / 5) {
				this.gameObject.SetActive(false);
				timer = 0;
			}

		}
	}
}