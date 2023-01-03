using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Trail : MonoBehaviour
{
    private float timer;

    public GameObject trailPrefab;
    private GameObject prefabObject;

	private int[] enemiesArray = new int[100];
	int i = 0;

    private void Update() {

        timer += Time.deltaTime;
        
        if (timer >= 0.1f) {
            timer = 0f;
            prefabObject = Instantiate(trailPrefab, transform.position, Quaternion.identity);
            prefabObject.GetComponent<WPN_Trail_Prefab>().parentObject = gameObject;
        }
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
		Debug.Log("Start");
		yield return new WaitForSeconds(0.2f);
		Debug.Log("Reset");
		enemiesArray[location] = 0;

	}
}
