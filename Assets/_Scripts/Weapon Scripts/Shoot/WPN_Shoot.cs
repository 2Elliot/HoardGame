using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

public class WPN_Shoot : MonoBehaviour
{

    float timer;
    
    private GameObject otherObject;

    public GameObject shootPrefab;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= ShootStats.coolDown) {
            timer = 0;
            StartCoroutine(CreateNewPrefab());
        }
    }

    IEnumerator CreateNewPrefab() {
        for (int i = 0; i < ShootStats.number; i++) {
            otherObject = Instantiate(shootPrefab, transform.position + new Vector3(1, 0, 0), Quaternion.identity);
            otherObject.GetComponent<WPN_Shoot_Prefab>().parentObject = gameObject;
            otherObject.GetComponent<WPN_Shoot_Prefab>().moveDirection = new Vector2(1, 0);
            yield return new WaitForSeconds(0.2f);
        }
    }

}
