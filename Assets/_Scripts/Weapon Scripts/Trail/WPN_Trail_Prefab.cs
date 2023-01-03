using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPN_Trail_Prefab : MonoBehaviour {
    private float timer;

    private float coolDown;

    private void Start() {
        coolDown = Singleton.Instance.waveCooldown;

		gameObject.transform.parent = null;
    }
    
    private void Update() {
        timer += Time.deltaTime;

        if (timer >= coolDown) {
    		Destroy(this.gameObject);
        }
    } 

}
