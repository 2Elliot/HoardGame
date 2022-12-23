using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Wave : MonoBehaviour
{
	[SerializeField] private GameObject waveObj;

	private float timer;

	private void Update() {
		timer += Time.deltaTime;

		if (timer > WaveStats.cooldown) {
			waveObj.SetActive(true);
			timer = 0;
		}
	}
}
