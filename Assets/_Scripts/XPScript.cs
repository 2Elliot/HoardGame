using UnityEngine;
using Stats;

public class XPScript : MonoBehaviour
{

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.CompareTag("Player")) {
			Player.xp++;
			Destroy(this.gameObject);
		}
	}

}
