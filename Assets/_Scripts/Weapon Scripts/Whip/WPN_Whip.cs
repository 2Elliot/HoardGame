using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPN_Whip : MonoBehaviour
{
	PlayerStats playerStats;

	private float timer = 0;
	float localTimer = 0;

	[SerializeField] GameObject leftWhip;
	[SerializeField] GameObject rightWhip;


	private void Awake() {
		playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
		if (playerStats == null) {
			Debug.Log("null");
		}
	}

	private void Update() {

		timer += Time.deltaTime;
		if (timer >= playerStats.whipSpeed) {
			attack();
		}
	}

	private void attack() {
		rightWhip.SetActive(true);
		leftWhip.SetActive(true);
		timer = 0;
	}

}
