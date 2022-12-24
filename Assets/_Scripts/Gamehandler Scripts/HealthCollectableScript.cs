using UnityEngine;
using Stats;
using System.Threading;
using System;

public class HealthCollectableScript : MonoBehaviour {
	float velocity = -0.1f;
	float tempSize;

	bool triggered;


	CircleCollider2D circleCollider;
	Transform player;

	InteractStats interactStats;

	private void Start() {
		circleCollider = GetComponent<CircleCollider2D>();
		circleCollider.radius = XpStats.size;
		tempSize = XpStats.size;
		player = GameObject.FindWithTag("Player").transform;

		interactStats = GameObject.FindWithTag("GameController").GetComponent<InteractStats>();
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.CompareTag("Player")) {
			circleCollider.enabled = false;
			triggered = true;
		}
	}

	private void FixedUpdate() {

		if (XpStats.size != tempSize) {
			circleCollider.radius = XpStats.size;
			tempSize = XpStats.size;
		}

		if (triggered) {
			if (Vector3.Distance(transform.position, player.transform.position) >= 0.2f) {
				transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocity);
				velocity += 0.01f;
			} else {
				if (PlayerStats.currentHp + (PlayerStats.maxHp / 5) <= PlayerStats.maxHp) {
					PlayerStats.currentHp += PlayerStats.maxHp / 5;
				} else {
					PlayerStats.currentHp = PlayerStats.maxHp;
				}
				interactStats.FetchStats();
				Destroy(this.gameObject);
			}
		}
	}
}
