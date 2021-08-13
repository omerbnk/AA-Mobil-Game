using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kucukcemberkod : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hız;
    bool hareketKontrol = false;
    GameObject oyunYoneticisi;
    public int numberOfok;

    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisi");
    }

    void FixedUpdate()
    {
        if (hareketKontrol == false) {
            fizik.MovePosition(fizik.position + Vector2.up * hız * Time.deltaTime);
        }
        
    }

  
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag =="donencember") {
            hareketKontrol = true;
            transform.SetParent(coll.transform);
        }
        if (coll.tag == "kucukcember") {
            oyunYoneticisi.GetComponent<oyunyoneticisi>().oyunBitti();
        }
    }
}
