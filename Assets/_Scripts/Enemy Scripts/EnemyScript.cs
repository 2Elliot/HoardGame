using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	private GameObject player;
	private Rigidbody2D enemyRigidbody2D;
	private AIBase aiBase;
	private AIDestinationSetter aiDestinationSetter;

	public GameObject xp;

	private EnemyHandler enemyHandler;

	private void Awake() {
		player = GameObject.FindGameObjectWithTag("Player");
		enemyHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<EnemyHandler>();
		enemyRigidbody2D = GetComponent<Rigidbody2D>();
		aiDestinationSetter = GetComponent<AIDestinationSetter>();
		aiBase = GetComponent<AIBase>();
	}

	private void Start() {
		aiBase.maxSpeed = enemyHandler.enemySpeed;
		aiDestinationSetter.target = player.transform;
	}

	public void KillSelf() {
		if (Random.Range(0, 2) == 0) {
			Instantiate(xp, transform.position, Quaternion.identity);
		}
		Destroy(this.gameObject);
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.CompareTag("Player")) {
			Destroy(this.gameObject);
			Debug.Log("Hit!");
		}
	}
}
