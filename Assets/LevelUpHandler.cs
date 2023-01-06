using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpHandler : MonoBehaviour
{

	public GameObject levelUpScreen;

    public void InitiateLevelUp() {
		Debug.Log("Level Up");
		levelUpScreen.SetActive(true);
	}
}
