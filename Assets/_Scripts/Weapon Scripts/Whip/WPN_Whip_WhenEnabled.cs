using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Whip_WhenEnabled : MonoBehaviour
{
	private float timer = 0;
	private bool isEnabled;

	private void OnEnable() {
		isEnabled = true;
	}

	private void Update() {
		if (isEnabled) {

			timer += Time.deltaTime;

			if (timer > Whip.speed / 5) {
				this.gameObject.SetActive(false);
				timer = 0;
			}

		}
	}
}
