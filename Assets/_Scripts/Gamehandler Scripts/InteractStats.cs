using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractStats : MonoBehaviour
{
	[SerializeField] private bool push;

    [SerializeField] private float Player_Speed;
	[SerializeField] private float Player_Range;
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
	[SerializeField] private float Trail_Length;

	[SerializeField] private int Shoot_Damage = 10;
	[SerializeField] private int Shoot_Number = 3;
	[SerializeField] private float Shoot_Spread = 15f;
	[SerializeField] private float Shoot_Distance = 2f;
	[SerializeField] private float Shoot_Speed = 20f;
	[SerializeField] private float Shoot_CoolDown = 2f;



	private void Start() {
		//FetchStats();
	}
	/*
	public void FetchStats() {
		Player_Speed = Singleton.Instance.playerspeed;
		Player_Range = Singleton.Instance.playerrange;
		Player_XP = Singleton.Instance.playerxp;
		Player_Level = Singleton.Instance.playerlevel;
		Player_MaxHp = Singleton.Instance.playermaxHp;
		Player_CurrentHp = Singleton.Instance.playercurrentHp;

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
		Trail_Length = TrailStats.length;

		Shoot_Damage = ShootStats.damage;
		Shoot_Number = ShootStats.number;
		Shoot_Spread = ShootStats.speed;
		Shoot_Distance = ShootStats.distance;
		Shoot_Speed = ShootStats.speed;
		Shoot_CoolDown = ShootStats.coolDown;
	}

	private void PushStats() {
		push = false;

		Debug.Log("Pushed Stats");

		Singleton.Instance.playerspeed = Player_Speed;
		Singleton.Instance.playerrange = Player_Range;
		Singleton.Instance.playerxp = Player_XP;
		Singleton.Instance.playerlevel = Player_Level;
		Singleton.Instance.playermaxHp = Player_MaxHp;
		Singleton.Instance.playercurrentHp = Player_CurrentHp;

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
		TrailStats.length = Trail_Length;

		ShootStats.damage = Shoot_Damage;
		ShootStats.number = Shoot_Number;
		ShootStats.spread = Shoot_Spread;
		ShootStats.distance = Shoot_Distance;
		ShootStats.speed = Shoot_Speed;
		ShootStats.coolDown = Shoot_CoolDown;
	}

	void Update()
    {
		if (push) {
			PushStats();
		}
	}
	*/
}
