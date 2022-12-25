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
			default:
				Debug.Log("WPN_Damage script returned null value");
				return 0;
		}
	}
}
