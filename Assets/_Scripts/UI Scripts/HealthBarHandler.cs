using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;
using UnityEngine.UI;

public class HealthBarHandler : MonoBehaviour {

	Slider slider;

	public GameObject deathScreen;

	int localHealth;
	int localMaxHealth;

	private void Start() {
		slider = GetComponent<Slider>();
		slider.maxValue = PlayerStats.maxHp;
	}

	void Die() {
		PlayerStats.currentHp = PlayerStats.maxHp;
		Debug.Log("Died");
		Time.timeScale = 0;
		deathScreen.SetActive(true);
	}

	void Update() {

		if (localHealth != PlayerStats.currentHp) {
			localHealth = PlayerStats.currentHp;
			slider.value = PlayerStats.currentHp;
		}

		if (localMaxHealth != PlayerStats.maxHp) {
			localMaxHealth = PlayerStats.maxHp;
			slider.maxValue = PlayerStats.maxHp;
		}

		if (PlayerStats.currentHp <= 0) {
			Die();
		}
	}
}
