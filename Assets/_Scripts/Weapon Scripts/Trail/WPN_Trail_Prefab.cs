using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Trail_Prefab : MonoBehaviour {
    private float timer;

    private void Start() {
        gameObject.transform.parent = null;
    }
    
    private void Update() {
        timer += Time.deltaTime;

        if (timer >= Trail.coolDown) {
    		Destroy(this.gameObject);
        }
    } 

}