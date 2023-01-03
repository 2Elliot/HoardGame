using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Trail_Prefab : MonoBehaviour {
    private float timer;

    public GameObject parentObject;

    WPN_Field wpn_Field;

    private void Start() {
        gameObject.transform.parent = null;
        gameObject.transform.localScale = Vector3.one * TrailStats.size;
    }
    
    private void Update() {
        timer += Time.deltaTime;

        if (timer >= TrailStats.coolDown) {
    		Destroy(this.gameObject);
        }
    } 

    public int DoDamage(int enemyID) {
        return parentObject.GetComponent<WPN_Trail>().DoDamage(enemyID);
    }
}
