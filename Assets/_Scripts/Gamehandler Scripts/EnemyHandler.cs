using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{

	public float enemySpeed = 5f;
	public float enemySpawnRate = 1f;

	public float enemyOneHealth = 50f;
	public float enemyTwoHealth = 100f;

	private float timer = 5f;
	private float time = 0f;

	private PlayerStats playerStats;

	private void Start() {
		playerStats = GetComponent<PlayerStats>();
	}

	private void Update() {
		time += Time.deltaTime;

		if (time >= timer) {
			time = 0f;
			enemySpawnRate = enemySpawnRate * 0.9f;
			enemySpeed += 0.1f;
		}
	}

	public float getEnemyHealth(int enemyNumber) {
		switch (enemyNumber) {
			case 1:
				return enemyOneHealth;
			case 2:
				return enemyTwoHealth;
			default:
				break;
		}
		return 0f;
	}

}
