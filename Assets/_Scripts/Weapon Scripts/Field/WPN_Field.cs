using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Field : MonoBehaviour
{

    float timer = 0;
	float localTimer = 0;

    void Update()
    {
        damageTimer();
    }

    void damageTimer() {
		timer += Time.deltaTime;
		if (timer >= Field.coolDown) {
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
