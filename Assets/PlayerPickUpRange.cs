using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpRange : MonoBehaviour
{
	private PlayerStats playerStats;

	private float tempRange;

	private void Awake() {
		playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
	}

	private void Update() {
		if (playerStats.playerRange!= tempRange) {
			tempRange = playerStats.playerRange;
			gameObject.transform.localScale = Vector3.one * playerStats.playerRange;
		}
	}

}
