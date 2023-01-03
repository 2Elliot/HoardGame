using UnityEngine;
using Stats;
using System.Threading;
using System;

public class Magnet : MonoBehaviour {
	float velocity = -0.1f;
	float tempSize;
	float temp;

	bool triggered;
	bool on;

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
			if (XpStats.size == 500) {
				Destroy(this.gameObject);
			}
			circleCollider.enabled = false;
			triggered = true;
			temp = XpStats.size;
			XpStats.size = 500f;
		}
	}

	private void FixedUpdate() {

		if (XpStats.size != tempSize) {
			circleCollider.radius = XpStats.size;
			tempSize = XpStats.size;
		}

		if (on) {
			XpStats.size = temp;
			Destroy(this.gameObject);
		}

		if (triggered) {
			if (Vector3.Distance(transform.position, player.transform.position) >= 0.25f) {
				transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocity);
				velocity += 0.005f;
			} else {
				on = true;
			}
		}

	}
}
