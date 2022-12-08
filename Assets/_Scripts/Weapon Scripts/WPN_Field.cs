using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPN_Field : MonoBehaviour
{

	PlayerStats playerStats;

    float timer = 0;
    void Start()
    {
    	playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
    }

    void Update()
    {
        damageTimer();
    }

    void damageTimer() {
        if (timer < playerStats.fieldCoolDown) {
            timer += Time.deltaTime;
        } else {
            timer = 0;

        }

    }

    void doDamage() {
        Debug.Log("wave");
        float localTimer = 0;
        GetComponent<Collider>().isTrigger = true;
        if (localTimer < 0.2f) {
            localTimer += Time.deltaTime;
        }
        GetComponent<Collider>().isTrigger = false;
    }

}
