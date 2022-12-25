using Pathfinding;
using Stats;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	private GameObject player;
	private Rigidbody2D enemyRigidbody2D;
	private AIBase aiBase;
	private AIDestinationSetter aiDestinationSetter;
	private Pathfinding.AIPath aiPath;
	
	public LayerMask mask;

	public GameObject xp;
	public GameObject health;
	public GameObject magnet;

	private EnemyHandler enemyHandler;

	public int enemyNumber;

	private void Awake() {
		player = GameObject.FindGameObjectWithTag("Player");
		enemyHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<EnemyHandler>();
		enemyRigidbody2D = GetComponent<Rigidbody2D>();
		aiDestinationSetter = GetComponent<AIDestinationSetter>();
		aiBase = GetComponent<AIBase>();
		aiPath = GetComponent<AIPath>();
	
	}

	private void Start() {
		aiPath.maxSpeed = enemyHandler.enemySpeed;

	}

	private void Update() {
		aiDestinationSetter.target = player.transform;
	}

	public void KillSelf() {
		if (!Physics2D.OverlapCircle(transform.position, 1f, mask)) {
			if (Random.Range(0, 2) == 0) {
				Instantiate(xp, transform.position, Quaternion.identity);
			} else if (Random.Range(0, 14) == 0) {
				Instantiate(health, transform.position, Quaternion.identity);
			} else if (Random.Range(0, 49) == 0) {
				Instantiate(magnet, transform.position, Quaternion.identity);
			}
		}
		Destroy(this.gameObject);
	}

	private void OnTriggerStay2D(Collider2D collision) {
		if (collision.CompareTag("Player")) {
			PlayerStats.currentHp -= enemyHandler.GetEnemyDamage(enemyNumber);
			Destroy(this.gameObject);
		}
	}
}
