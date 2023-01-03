using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePanel : MonoBehaviour
{

    [SerializeField] public UpgradeScreenScriptableObject[] upgrades;

	private UpgradeScreenScriptableObject[,,] fixedUpgrades;

	private void Start() {
		for (int i = 0; i < upgrades.Length; i++) {
			fixedUpgrades[upgrades[i].weaponInt, upgrades[i].upgradeInt, upgrades[i].rarityInt] = upgrades[i];
		}
	}

	public void GenerateRandomUpgrade() {
        int randomWeapon = Random.Range(0, 1);
		int randomUpgradeType = Random.Range(0, 1);
		int randomValue = Random.Range(1, 17);
		for (int l = 0; l < 4; l++) {
			if (fixedUpgrades[j, k, l].minRarity <= randomValue && fixedUpgrades[j, k, l].maxRarity >= randomValue) {

			}
		}
	}
		

}
