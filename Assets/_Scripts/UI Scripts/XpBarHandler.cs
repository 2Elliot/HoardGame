using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XpBarHandler : MonoBehaviour
{

    Slider slider;

    int currentXp; // Reset when reaches next level
    int localXp; // Compares tempXp and xp

    private int maxXp;
    private int level;
    private int xp;

	private void Start() {
        maxXp = Singleton.Instance.xpMax;
        level = Singleton.Instance.playerLevel;
        xp = Singleton.Instance.playerXP;

		slider = GetComponent<Slider>();
        slider.maxValue = maxXp;
	}

	void ResetXp() {
        currentXp = 0;
        slider.value = 0;
        maxXp += (maxXp / 8);
        slider.maxValue = maxXp;
        level++;
    }

    void Update()
    {
        if (currentXp >= maxXp) {
            ResetXp();
        }

        slider.value = currentXp;

        if (localXp != xp) {
            currentXp += xp - localXp;
            localXp = xp;
        }
    }
}
