using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Field : MonoBehaviour
{
	private int[] enemiesArray = new int[100];
	int i = 0;

	public int DoDamage(int enemy) {
		if (!HasDuplicate(enemy)) {
			StartCoroutine(DamageCoolDown(enemy));
			i++;
			return FieldStats.damage;
		}
		return 0;
	}

	private bool HasDuplicate(int value) {
		if (i >= enemiesArray.Length) i = 0;
		for (int j = 0; j < enemiesArray.Length; j++) {
			if (enemiesArray[j] == value) {
				return true;
			}
		}
		return false;
	}

	IEnumerator DamageCoolDown(int enemyID) {
		int location = i;
		enemiesArray[i] = enemyID;
		yield return new WaitForSeconds(FieldStats.coolDown);
		enemiesArray[location] = 0;

	}
}
