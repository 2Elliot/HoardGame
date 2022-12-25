using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour
{
    EnemyHandler enemyHandler;
	EnemyScript enemyScript;


	public int enemyNumber;

	private float time;

    [HideInInspector] public int health;    

    void Awake() {
        enemyHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<EnemyHandler>();
		enemyScript = GetComponent<EnemyScript>();
        health = enemyHandler.GetEnemyHealth(enemyNumber);
	}

	private void OnTriggerStay2D(Collider2D collision) {
		if (collision.CompareTag("weapon")) {
			time = 0f;
			health -= collision.GetComponent<WPN_Damage>().DoDamage(GetInstanceID());
		}
	}

	private void Update() {
		if (health <= 0) {
			enemyScript.KillSelf();
		}
		time += Time.deltaTime;
	}
}
