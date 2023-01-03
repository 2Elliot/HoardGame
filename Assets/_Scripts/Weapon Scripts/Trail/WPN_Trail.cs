using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Trail : MonoBehaviour
{
    public GameObject trailPrefab;

    private GameObject otherObject;

	private int[] enemiesArray = new int[100];
	int i = 0;

    IEnumerator CreateNewPrefab() {
        otherObject = Instantiate(trailPrefab, transform.position, Quaternion.identity);
        otherObject.GetComponent<WPN_Trail_Prefab>().parentObject = gameObject;
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(CreateNewPrefab());
    }

    private void Start() {
        
        StartCoroutine(CreateNewPrefab());

    }
    
	public int DoDamage(int enemy) {
		if (!HasDuplicate(enemy)) {
			StartCoroutine(DamageCoolDown(enemy));
			i++;
			return TrailStats.damage;
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
		yield return new WaitForSeconds(0.2f);
		enemiesArray[location] = 0;

	}
}
