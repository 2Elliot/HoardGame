using UnityEngine;
using System.Threading;
using System;

public class XPScript : MonoBehaviour
{
	float velocity = -0.1f;
	float tempSize;

	bool triggered;

	private float size;
	private int currentXP;

	CircleCollider2D circleCollider;
	Transform player;

	InteractStats interactStats;

	private void Start() {
		size = Singleton.Instance.xpSize;
		currentXP = Singleton.Instance.playerXP;

		circleCollider = GetComponent<CircleCollider2D>();
		circleCollider.radius = size;
		tempSize = size;
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

		if (size != tempSize) {
			circleCollider.radius = size;
			tempSize = size;
		}

		if (triggered) {
			if (Vector3.Distance(transform.position, player.transform.position) >= 0.2f) {
				transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocity);
				velocity += 0.01f;
			} else {
				currentXP++;
				//interactStats.FetchStats();
				Destroy(this.gameObject);
			}
		}
	}
}
