using UnityEngine;

public class WPN_Whip : MonoBehaviour
{
	private float timer = 0;

	private int[] enemiesArray = new int[100];
	int i = 0;

	private int damage;
	private float length;
	private float speed;

	[SerializeField] GameObject leftWhip;
	[SerializeField] GameObject rightWhip;

	private void Start() {
		damage = Singleton.Instance.whipDamage;
		length = Singleton.Instance.whipLength;
		speed = Singleton.Instance.whipSpeed;
	}

	private void Update() {

		timer += Time.deltaTime;
		if (timer >= speed) {
			attack();
		}
	}

	private void attack() {
		for (int k = 0; k < enemiesArray.Length; k++) {
			enemiesArray[k] = 0;
		}
		i = 0;
		rightWhip.SetActive(true);
		leftWhip.SetActive(true);
		timer = 0;
	}

	public int DoDamage(int enemy) {
		if (!HasDuplicate(enemy)) {
			i++;
			return damage;
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
}
