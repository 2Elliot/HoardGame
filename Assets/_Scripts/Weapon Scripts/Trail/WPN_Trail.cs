using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPN_Trail : MonoBehaviour
{
    private float timer;

    public GameObject trailPrefab;

    private void Update() {

        timer += Time.deltaTime;
        
        if (timer >= 0.1f) {
            timer = 0f;
            Instantiate(trailPrefab, transform.position, Quaternion.identity);
        }

    }
}
