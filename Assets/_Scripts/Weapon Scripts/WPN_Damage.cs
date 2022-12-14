using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

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
			case ("Trail"):
				return transform.GetComponent<WPN_Trail_Prefab>().DoDamage(weaponID);
			default:
				Debug.Log("WPN_Damage script returned null value");
				return 0;
		}
	}
}
