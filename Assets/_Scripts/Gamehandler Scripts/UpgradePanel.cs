using UnityEngine;
using UnityEngine.UI;

public class UpgradePanel : MonoBehaviour
{

    public UpgradeScreenScriptableObject[] upgrades;

	private UpgradeScreenScriptableObject[,,] fixedUpgrades;

	private Image upgradeImage;

	private void Start() {
		upgradeImage = GetComponent<Image>();

		for (int i = 0; i < upgrades.Length; i++) {
			fixedUpgrades[upgrades[i].weaponInt, upgrades[i].upgradeInt, upgrades[i].rarityInt] = upgrades[i];
		}
	}

	public void GenerateRandomUpgrade() {
        int randomWeapon = Random.Range(0, 1);
		int randomUpgradeType = Random.Range(0, 1);
		int randomValue = Random.Range(1, 17);
		for (int l = 0; l < 4; l++) {
			if (fixedUpgrades[randomWeapon, randomUpgradeType, l].minRarity <= randomValue && fixedUpgrades[randomWeapon, randomUpgradeType, l].maxRarity >= randomValue) {
				FillUpgrade(fixedUpgrades[randomWeapon, randomUpgradeType, l]);
			}
		}
	}

	private void FillUpgrade(UpgradeScreenScriptableObject input) {
		upgradeImage = input.image;
	}
}
