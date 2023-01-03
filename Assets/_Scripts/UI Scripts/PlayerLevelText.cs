using UnityEngine;
using TMPro;

public class PlayerLevelText : MonoBehaviour
{

    TMP_Text text;

	int tempLevel = -1;

	private int level;

	private void Start() {
		level = Singleton.Instance.playerLevel;

		text = GetComponent<TMP_Text>();
	}

	void Update()
    {
		if (tempLevel != level) {
			tempLevel = level;
			text.text = level.ToString();
		}
    }
}
