using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidYokEt : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ammo")
        {
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
