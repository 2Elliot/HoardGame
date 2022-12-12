using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPN_Field : MonoBehaviour
{

	PlayerStats playerStats;

    float timer = 0;
	float localTimer = 0;

	void Start()
    {
    	playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
    }

    void Update()
    {
        damageTimer();
    }

    void damageTimer() {
		timer += Time.deltaTime;
		if (timer >= playerStats.fieldCoolDown) {
            doDamage();
        }

    }

    void doDamage() {
        GetComponent<CircleCollider2D>().enabled = true;
        if (localTimer >= 0.2f) {
            GetComponent<CircleCollider2D>().enabled = false;
            localTimer = 0f;
			timer = 0;
		} else {
			localTimer += Time.deltaTime;
		}
	}

}
