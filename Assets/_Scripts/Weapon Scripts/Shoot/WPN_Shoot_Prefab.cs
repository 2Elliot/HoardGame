using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Shoot_Prefab : MonoBehaviour
{

    [HideInInspector] public GameObject parentObject;
    [HideInInspector] public Vector3 moveDirection;
    private float timer;

    private BoxCollider2D boxCollider;

    private int[] enemiesArray = new int[100];
	int i = 0;

    void Start() {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        transform.position += moveDirection * Time.deltaTime * ShootStats.speed;

        if (timer >= ShootStats.distance) {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Enemy")){
           StartCoroutine(DestroySelf());
        }
    }

	public int DoDamage(int enemy) {
		if (!HasDuplicate(enemy)) {
			i++;
			return ShootStats.damage;
		}
		return 0;
	}

	private bool HasDuplicate(int value) {
		for (int j = 0; j < enemiesArray.Length; j++) {
			if (enemiesArray[j] == value) {
				return true;
			}
		}
		enemiesArray[i] = value;
		return false;
	}

    IEnumerator DestroySelf() {
        yield return null;
       //boxCollider.isEnabled(false);
    }
}
