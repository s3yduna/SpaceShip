using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKlavye : MonoBehaviour
{
    // Start is called before the first frame update


    const float hareketGucu = 10;

    [SerializeField]
    GameObject ammoPrefab;
    [SerializeField]
    GameObject patlamaPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 position = transform.position;

        float yatayInput = Input.GetAxis("Horizontal");
        float dikeyInput = Input.GetAxis("Vertical");

        if (yatayInput != 0) 
        {
            position.x += yatayInput * hareketGucu * Time.deltaTime;
        }

        if (dikeyInput != 0) 
        {
            position.y += dikeyInput * hareketGucu * Time.deltaTime;
        }

        transform.position = position;


        if (Input.GetButtonDown("Jump"))
        {
            Vector3 ammoPozisyon = gameObject.transform.position;
            Instantiate(ammoPrefab, ammoPozisyon, Quaternion.identity);
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "asteroid")
        {
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
