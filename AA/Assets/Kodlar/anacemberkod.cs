using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class anacemberkod : MonoBehaviour
{
    public GameObject kucukCember;
    int cemberSayısı = 0;
    GameObject anacember;
    GameObject donencember;
    public Text sayac;
    int x = 2;
    bool kontrol = false;
    public Animator animator;
    public bool yanmak = true;
   


    void Start()
    {
        donencember = GameObject.FindGameObjectWithTag("donencember");
        anacember = GameObject.FindGameObjectWithTag("anacember");
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1") || kontrol) {
            kucukCemberOlustur();
            cemberSayısı++;
            sayac.text = "Top : " + cemberSayısı;

        }
        if (cemberSayısı == 10)
        {
            StartCoroutine(nextLevel());
        }

    }

    IEnumerator nextLevel() {
        anacember.GetComponent<anacemberkod>().enabled = false;
        donencember.GetComponent<donencemberkod>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        animator.SetTrigger("yenilevel");
        yield return new WaitForSeconds(1);
        int level = int.Parse(SceneManager.GetActiveScene().name);
        if (level < 4 && yanmak) {
            SceneManager.LoadScene(level + 1);
        }


    }

    void kucukCemberOlustur() {
        Instantiate(kucukCember, transform.position, transform.rotation);
    }

    public void button() {
        kontrol = true;
        bos();

    }
    void bos() {
        kontrol = false;
    }
  
   

}
