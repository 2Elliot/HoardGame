using UnityEngine;
using System.Threading;
using System;

public class HealthCollectableScript : MonoBehaviour {
	float velocity = -0.1f;
	float tempSize;

	bool triggered;

	private float xpSize;
	private int maxHp;
	private int currentHp;

	CircleCollider2D circleCollider;
	Transform player;

	InteractStats interactStats;

	private void Start() {
		xpSize = Singleton.Instance.xpSize;
		maxHp = Singleton.Instance.playerMaxHp;
		currentHp = Singleton.Instance.playerCurrentHp;


		circleCollider = GetComponent<CircleCollider2D>();
		circleCollider.radius = xpSize;
		tempSize = xpSize;
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

		if (xpSize != tempSize) {
			circleCollider.radius = xpSize;
			tempSize = xpSize;
		}

		if (triggered) {
			if (Vector3.Distance(transform.position, player.transform.position) >= 0.2f) {
				transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocity);
				velocity += 0.01f;
			} else {
				if (currentHp + (maxHp / 5) <= maxHp) {
					currentHp +=maxHp / 5;
				} else {
					currentHp =maxHp;
				}
				//interactStats.FetchStats();
				Destroy(this.gameObject);
			}
		}
	}
}
