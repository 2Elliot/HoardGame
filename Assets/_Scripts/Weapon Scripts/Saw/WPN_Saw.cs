using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Saw : MonoBehaviour {
	
	GameObject player;

	void Start() {
		player = GameObject.FindWithTag("Player");
		transform.position = transform.position + new Vector3(0f, SawStats.area, 0f);
	}

	void Update() {
        transform.RotateAround(player.transform.position, new Vector3(0, 0, -1), SawStats.speed * Time.deltaTime);
		transform.Rotate(new Vector3(0, 0, 1), 5f);
    }
}
