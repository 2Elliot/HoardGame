using UnityEngine;

public class WPN_Whip_WhenEnabled : MonoBehaviour
{
	private float timer = 0;
	private bool isEnabled;

	private float length;

	private void Start() {
		length = Singleton.Instance.whipLength;
	}

	private void OnEnable() {
		isEnabled = true;
	}

	private void Update() {
		if (isEnabled) {

			timer += Time.deltaTime;

			if (timer > length) {
				gameObject.SetActive(false);
				timer = 0;
			}

		}
	}




}
