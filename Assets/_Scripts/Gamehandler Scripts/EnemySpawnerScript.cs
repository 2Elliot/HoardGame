using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

	private GameObject player;

	private PlayerStats playerStats;

	public GameObject enemy;

	private EnemyHandler enemyHandler;

	private float timer;

	//Vector3 scale = transform.localScale;


	private void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
		// playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<playerStats>();
		enemyHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<EnemyHandler>();
		Vector3 scale = transform.localScale;

	}

	private void Update() {
		transform.position = player.transform.position;
		//scale.Set(playerStats.fieldSize, playerStats.fieldSize, 0f);
		SpawnEnemies();
	}

	private void SpawnEnemies() {
		if (timer <= enemyHandler.enemySpawnRate) {
			timer += Time.deltaTime;
		} else {
			timer = 0;
			float randFloat = Random.Range(0, 2 * Mathf.PI);
			float spawnX = Mathf.Sin(randFloat);
			float spawnY = Mathf.Cos(randFloat);
			Instantiate(enemy, transform.position + new Vector3(spawnX, spawnY, 0f) * 20, Quaternion.identity);
		}
	}

}
