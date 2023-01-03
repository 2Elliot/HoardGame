using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class WPN_Saw : MonoBehaviour {
	
	GameObject player;

	private int[] enemiesArray = new int[100];
	int i = 0;

	private int damage;
	private float area;
	private float speed;

	void Start() {
		damage = Singleton.Instance.sawDamage;
		area = Singleton.Instance.sawArea;
		speed = Singleton.Instance.sawSpeed;

		player = GameObject.FindWithTag("Player");
		transform.position = transform.position + new Vector3(0f, area, 0f);
	}

	void Update() {
        transform.RotateAround(player.transform.position, new Vector3(0, 0, -1), speed * Time.deltaTime);
		transform.Rotate(new Vector3(0, 0, 1), 5f);
    }

	public int DoDamage(int enemy) {
		if (!HasDuplicate(enemy)) {
			StartCoroutine(DamageCoolDown(enemy));
			i++;
			return damage;
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
		yield return new WaitForSeconds(0.5f);
		enemiesArray[location] = 0;

	}

}
