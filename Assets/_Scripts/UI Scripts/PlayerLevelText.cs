using UnityEngine;
using Stats;
using TMPro;

public class PlayerLevelText : MonoBehaviour
{

    TMP_Text text;

	int tempLevel = -1;

	private void Start() {
		text = GetComponent<TMP_Text>();
	}

	void Update()
    {
		if (tempLevel != PlayerStats.level) {
			tempLevel = PlayerStats.level;
			text.text = PlayerStats.level.ToString();
		}
    }
}
