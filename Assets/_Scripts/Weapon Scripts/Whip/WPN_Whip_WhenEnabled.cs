using UnityEngine;
using Stats;
using System;
using System.Collections.Generic;

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

			if (timer > WhipStats.length) {
				gameObject.SetActive(false);
				timer = 0;
			}

		}
	}




}
