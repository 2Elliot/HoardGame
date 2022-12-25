using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnStart : MonoBehaviour
{

    public GameObject[] objectsToBeActivated;

    void Awake()
    {

        for (int i = 0; i < objectsToBeActivated.Length; i++) {
            objectsToBeActivated[i].SetActive(true);
        }

    }
}
