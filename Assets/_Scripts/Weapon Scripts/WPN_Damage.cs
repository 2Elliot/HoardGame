using UnityEngine;

public class WPN_Damage : MonoBehaviour
{
	[SerializeField] string weaponScriptName;

	public int DoDamage(int weaponID) {
		switch(weaponScriptName) {
			case ("Whip"):
				return transform.parent.GetComponent<WPN_Whip>().DoDamage(weaponID);
			case ("Wave"):
				return transform.parent.GetComponent<WPN_Wave>().DoDamage(weaponID);
			case ("Saw"):
				return transform.GetComponent<WPN_Saw>().DoDamage(weaponID);
			case ("Field"):
				return transform.GetComponent<WPN_Field>().DoDamage(weaponID);
			default:
				Debug.Log("WPN_Damage null value");
				return 0;
		}
	}
}
