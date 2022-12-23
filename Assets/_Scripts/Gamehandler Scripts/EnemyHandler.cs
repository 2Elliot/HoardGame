using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{

	public float enemySpeed = 5f;
	public float enemySpawnRate = 1f;

	public int enemyOneHealth = 50;
	public int enemyTwoHealth = 100;

	private float timer = 5f;
	private float time = 0f;


	private void Update() {
		time += Time.deltaTime;

		if (time >= timer) {
			time = 0f;
			enemySpawnRate = enemySpawnRate * 0.9f;
			enemySpeed += 0.1f;
		}
	}

	public int getEnemyHealth(int enemyNumber) {
		switch (enemyNumber) {
			case 1:
				return enemyOneHealth;
			case 2:
				return enemyTwoHealth;
			default:
				break;
		}
		return 0;
	}

}
