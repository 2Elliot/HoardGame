using UnityEngine;
using System.Threading;
using System;

public class Magnet : MonoBehaviour {
	float velocity = -0.1f;
	float tempSize;
	float temp;

	bool triggered;
	bool on;

	private float size;
	private int xpMax;

	CircleCollider2D circleCollider;
	Transform player;

	InteractStats interactStats;

	private void Start() {
		size = Singleton.Instance.xpSize;
		xpMax = Singleton.Instance.xpMax;

		circleCollider = GetComponent<CircleCollider2D>();
		circleCollider.radius = size;
		tempSize = size;
		player = GameObject.FindWithTag("Player").transform;

		interactStats = GameObject.FindWithTag("GameController").GetComponent<InteractStats>();
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.CompareTag("Player")) {
			if (size == 500) {
				Destroy(this.gameObject);
			}
			circleCollider.enabled = false;
			triggered = true;
			temp = size;
			size = 500f;
		}
	}

	private void FixedUpdate() {

		if (size != tempSize) {
			circleCollider.radius = size;
			tempSize = size;
		}

		if (on) {
			size = temp;
			Destroy(this.gameObject);
		}

		if (triggered) {
			if (Vector3.Distance(transform.position, player.transform.position) >= 0.2f) {
				transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocity);
				velocity += 0.005f;
			} else {
				on = true;
			}
		}

	}
}
