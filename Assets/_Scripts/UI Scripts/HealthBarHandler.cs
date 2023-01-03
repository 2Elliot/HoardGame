using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarHandler : MonoBehaviour {

	Slider slider;

	public GameObject deathScreen;

	int localHealth;
	int localMaxHealth;

	private int maxHp;
	private int currentHp;

	private void Start() {
		maxHp = Singleton.Instance.playerMaxHp;
		currentHp = Singleton.Instance.playerCurrentHp;

		slider = GetComponent<Slider>();
		slider.maxValue = maxHp;
	}

	void Die() {
		PlayerStats.currentHp = PlayerStats.maxHp;
		Debug.Log("Died");
		Time.timeScale = 0;
		deathScreen.SetActive(true);
	}

	void Update() {

		if (localHealth != currentHp) {
			localHealth = currentHp;
			slider.value = currentHp;
		}

		if (localMaxHealth != maxHp) {
			localMaxHealth = maxHp;
			slider.maxValue = maxHp;
		}

		if (currentHp <= 0) {
			Die();
		}
	}
}
