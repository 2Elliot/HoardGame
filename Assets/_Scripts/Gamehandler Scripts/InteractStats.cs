using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class InteractStats : MonoBehaviour
{
	[SerializeField] private bool push;

    [SerializeField] [Range(0.0f, 50.0f)] private float Player_Speed;
	[SerializeField] [Range(0.0f, 30.0f)] private float Player_Range;
	[SerializeField] private int Player_XP;
	[SerializeField] private int Player_Level;
	[SerializeField] private int Player_MaxHp;
	[SerializeField] private int Player_CurrentHp;


	[SerializeField] private float XP_Size;

	[SerializeField] private float Saw_Area;
	[SerializeField] private int Saw_Damage;
	[SerializeField] private float Saw_Speed;

	[SerializeField] private float Field_Size;
	[SerializeField] private int Field_Damage;
	[SerializeField] private float Field_CoolDown;

	[SerializeField] private int Whip_Damage;
	[SerializeField] private float Whip_Length;
	[SerializeField] private float Whip_Speed;

	[SerializeField] private int Wave_Damage;
	[SerializeField] private float Wave_CoolDown;
	[SerializeField] private float Wave_Speed;

	[SerializeField] private int Trail_Damage;
	[SerializeField] private float Trail_CoolDown;
	[SerializeField] private float Trail_Size;

	private void Start() {
		FetchStats();
	}

	public void FetchStats() {
		Player_Speed = PlayerStats.speed;
		Player_Range = PlayerStats.range;
		Player_XP = PlayerStats.xp;
		Player_Level = PlayerStats.level;
		Player_MaxHp = PlayerStats.maxHp;
		Player_CurrentHp = PlayerStats.currentHp;

		XP_Size = XpStats.size;

		Saw_Area = SawStats.area;
		Saw_Damage = SawStats.damage;
		Saw_Speed = SawStats.speed;

		Field_Size = FieldStats.size;
		Field_Damage = FieldStats.damage;
		Field_CoolDown = FieldStats.coolDown;

		Whip_Damage = WhipStats.damage;
		Whip_Length = WhipStats.length;
		Whip_Speed = WhipStats.speed;

		Wave_Damage = WaveStats.damage;
		Wave_CoolDown = WaveStats.cooldown;
		Wave_Speed = WaveStats.speed;

		Trail_Damage = TrailStats.damage;
		Trail_CoolDown = TrailStats.coolDown;
		Trail_Size = TrailStats.size;
	}

	private void PushStats() {
		push = false;

		Debug.Log("Pushed Stats");

		PlayerStats.speed = Player_Speed;
		PlayerStats.range = Player_Range;
		PlayerStats.xp = Player_XP;
		PlayerStats.level = Player_Level;
		PlayerStats.maxHp = Player_MaxHp;
		PlayerStats.currentHp = Player_CurrentHp;

		XpStats.size = XP_Size;

		SawStats.area = Saw_Area;
		SawStats.damage = Saw_Damage;
		SawStats.speed = Saw_Speed;

		FieldStats.size = Field_Size;
		FieldStats.damage = Field_Damage;
		FieldStats.coolDown = Field_CoolDown;

		WhipStats.damage = Whip_Damage;
		WhipStats.length = Whip_Length;
		WhipStats.speed = Whip_Speed;

		WaveStats.damage = Wave_Damage;
		WaveStats.cooldown = Wave_CoolDown;
		WaveStats.speed = Wave_Speed;

		TrailStats.damage = Trail_Damage;
		TrailStats.coolDown = Trail_CoolDown;
		TrailStats.size = Trail_Size;
	}

	void Update()
    {
		if (push) {
			PushStats();
		}
	}
}


