using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{

	EnemyHealthScript enemyHealthScript;
	EnemyAnimationHandler enemyAnimationHandler;
	Slider slider;

	private int tempHealth;

	private void Start() {
		enemyHealthScript = transform.parent.transform.parent.transform.parent.gameObject.GetComponent<EnemyHealthScript>();
		enemyAnimationHandler = transform.parent.transform.parent.gameObject.GetComponent<EnemyAnimationHandler>();
		slider = GetComponent<Slider>();
		slider.maxValue = enemyHealthScript.health;
		tempHealth = enemyHealthScript.health;
		slider.value = slider.maxValue;
		enemyAnimationHandler.LooseParent();
	}

	void Update()
    {
        if (tempHealth != enemyHealthScript.health) {
			slider.value = enemyHealthScript.health;
			tempHealth= enemyHealthScript.health;
		}
    }
}
