using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Damage : MonoBehaviour
{
	[HideInInspector] public float weaponDamage;
	[SerializeField] string weaponName;

	private void Start() {
		switch(weaponName) {
			case "saw":
				weaponDamage = SawStats.damage;
				break;
			case "field":
				weaponDamage = FieldStats.damage;
				break;
			case "shoot":
				//weaponDamage = ShootStats.damage;
				break;
			case "trail":
				weaponDamage = TrailStats.damage;
				break;
			case "lightning":
				//weaponDamage = LightningStats.damage;
				break;
			case "sword":
				//weaponDamage = SwordStats.damage;
				break;
			case "hole":
				//weaponDamage = HoleStats.damage;
				break;
			case "wave":
				weaponDamage = WaveStats.damage;
				break;
			case "whip":
				weaponDamage = WhipStats.damage;
				break;

		}
	}
}
