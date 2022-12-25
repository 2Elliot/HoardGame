using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Wave : MonoBehaviour
{
	[SerializeField] private GameObject waveObj;

	private int[] enemiesArray = new int[100];
	int i = 0;

	private float timer;

	private void Update() {
		timer += Time.deltaTime;

		if (timer > WaveStats.cooldown) {
			for (int k = 0; k < enemiesArray.Length; k++) {
				enemiesArray[k] = 0;
			}
			waveObj.SetActive(true);
			timer = 0;
		}
	}

	public int DoDamage(int enemy) {
		if (!HasDuplicate(enemy)) {
			i++;
			return WaveStats.damage;
		}
		return 0;
	}

	private bool HasDuplicate(int value) {
		for (int j = 0; j < enemiesArray.Length; j++) {
			if (enemiesArray[j] == value) {
				return true;
			}
		}
		try {
			enemiesArray[i] = value;
		}
		catch {
			Debug.Log("WPN_Wave Enemies overload");
			for (int k = 0; k < enemiesArray.Length; k++) {
				enemiesArray[k] = 0;
			}
			i = 0;
		}
		return false;
	}
}
