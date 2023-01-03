using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;
using System;

public class WPN_Whip : MonoBehaviour
{
	private float timer = 0;

	private int[] enemiesArray = new int[100];
	int i = 0;

	[SerializeField] GameObject leftWhip;
	[SerializeField] GameObject rightWhip;

	private void Update() {

		timer += Time.deltaTime;
		if (timer >= WhipStats.speed) {
			attack();
		}
	}

	private void attack() {
		for (int k = 0; k < enemiesArray.Length; k++) {
			enemiesArray[k] = 0;
		}
		i = 0;
		rightWhip.SetActive(true);
		leftWhip.SetActive(true);
		timer = 0;
	}

	public int DoDamage(int enemy) {
		if (!HasDuplicate(enemy)) {
			i++;
			return WhipStats.damage;
		}
		return 0;
	}

	private bool HasDuplicate(int value) {
		for (int j = 0; j < enemiesArray.Length; j++) {
			if (enemiesArray[j] == value) {
				return true;
			}
		}
		enemiesArray[i] = value;
		return false;
	}
}
