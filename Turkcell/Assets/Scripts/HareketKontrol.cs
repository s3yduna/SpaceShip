using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    

    void Start()
    {
        Rigidbody2D myRB2D = GetComponent<Rigidbody2D>();
        myRB2D.AddForce(new Vector2(Random.Range(-5,5), Random.Range(-5,5)), ForceMode2D.Impulse);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("Çarpýþma Uyarýsý!");
    //}


    
}
