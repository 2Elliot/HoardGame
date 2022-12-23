using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Whip : MonoBehaviour
{
	private float timer = 0;

	[SerializeField] GameObject leftWhip;
	[SerializeField] GameObject rightWhip;

	private void Update() {

		timer += Time.deltaTime;
		if (timer >= WhipStats.speed) {
			attack();
		}
	}

	private void attack() {
		rightWhip.SetActive(true);
		leftWhip.SetActive(true);
		timer = 0;
	}

}
