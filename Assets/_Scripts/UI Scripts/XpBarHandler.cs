using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;
using UnityEngine.UI;

public class XpBarHandler : MonoBehaviour
{

    Slider slider;

    int currentXp; // Reset when reaches next level
    int localXp; // Compares tempXp and PlayerStats.xp

	private void Start() {
        slider = GetComponent<Slider>();
        slider.maxValue = XpStats.maxXp;
	}

	void ResetXp() {
        currentXp = 0;
        slider.value = 0;
        XpStats.maxXp += (XpStats.maxXp / 8);
        slider.maxValue = XpStats.maxXp;
        PlayerStats.level++;
    }

    void Update()
    {
        if (currentXp >= XpStats.maxXp) {
            ResetXp();
        }

        slider.value = currentXp;

        if (localXp != PlayerStats.xp) {
            currentXp += PlayerStats.xp - localXp;
            localXp = PlayerStats.xp;
        }
    }
}
