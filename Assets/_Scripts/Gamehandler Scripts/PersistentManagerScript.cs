using UnityEngine;

public class Singleton : MonoBehaviour {

	public static Singleton Instance { get; private set; }

	// Player Stats
	public float playerSpeed = 15f;
	public float playerRange = 2f;
	public int playerXP = 0;
	public int playerLevel = 0;
	public int playerMaxHp = 100;
	public int playerCurrentHp = 100;

	// Xp Stats
	public float xpSize = 3f;
	public int xpMax = 25;

	// Saw Stats
	public int sawDamage = 25;
	public float sawArea = 3f;
	public float sawSpeed = 200f;

	// Field Stats
	public int fieldDamage = 5;
	public float fieldSize = 3f;
	public float fieldCoolDown = 0.05f;

	// Whip Stats
	public int whipDamage = 25;
	public float whipLength = 0.5f;
	public float whipSpeed = 2f;

	// Wave Stats
	public int waveDamage = 50;
	public float waveCooldown = 30f;
	public float waveSpeed = 0.3f;

	// Trail Stats
	public int trailDamage = 1;
	public float trailSize = 1f;
	public float trailCoolDown = 2f;



	private void Awake() {
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad(gameObject);
		} else {
			Destroy(gameObject);
		}
	}

}
