using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    void Start()
    {

        for (int i = 0; i < 0; i++)
        {
            Instantiate(asteroidPrefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
