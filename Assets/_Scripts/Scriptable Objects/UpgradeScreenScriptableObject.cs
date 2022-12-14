using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/UpgradeScreen", order = 1)]
public class UpgradeScreenScriptableObject : ScriptableObject {
	public Image image;
	public float minRarity;
	public float maxRarity;
	public string weaponName;
	public string upgradeType;
	public float upgradeAmount;

	public int weaponInt;
	public int upgradeInt;
	public int rarityInt;
}
