using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPN_Wave : MonoBehaviour
{
	[SerializeField] private GameObject waveObj;

	private int[] enemiesArray = new int[100];
	int i = 0;

	private float timer;

	private int damage;
	private float coolDown;
	private float speed;

	private void Start() {
		damage = Singleton.Instance.waveDamage;
		coolDown = Singleton.Instance.waveCooldown;
		speed = Singleton.Instance.waveSpeed;
	}

	private void Update() {
		timer += Time.deltaTime;

		if (timer > coolDown) {
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
			return damage;
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
