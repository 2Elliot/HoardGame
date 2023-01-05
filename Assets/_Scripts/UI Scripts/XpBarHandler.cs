using UnityEngine;
using Stats;
using UnityEngine.UI;

public class XpBarHandler : MonoBehaviour
{

    Slider slider;

    LevelUpHandler levelUpHandler;

    int currentXp; // Reset when reaches next level
    int localXp; // Compares tempXp and PlayerStats.xp

	private void Start() {
        slider = GetComponent<Slider>();
        slider.maxValue = XpStats.maxXp;

        levelUpHandler = GameObject.FindWithTag("GameController").GetComponent<LevelUpHandler>();
	}

	void ResetXp() {
        currentXp = 0;
        slider.value = 0;
        XpStats.maxXp += (XpStats.maxXp / 8);
        slider.maxValue = XpStats.maxXp;
        PlayerStats.level++;
        levelUpHandler.InitiateLevelUp();
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
