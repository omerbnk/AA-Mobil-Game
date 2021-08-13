using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunyoneticisi : MonoBehaviour
{

    GameObject donencember;
    GameObject anacember;
    public Animator animator;
    void Start()
    {
        donencember = GameObject.FindGameObjectWithTag("donencember");
        anacember = GameObject.FindGameObjectWithTag("anacember");
    }

    public void oyunBitti() {
        anacember.GetComponent<anacemberkod>().enabled = false;
        donencember.GetComponent<donencemberkod>().enabled = false;
        animator.SetTrigger("oyunbitti");
        StartCoroutine(loadScene());

    }
    IEnumerator loadScene() {
        anacember.GetComponent<anacemberkod>().yanmak = false; 
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("AnaMenu");
      
    }

}
