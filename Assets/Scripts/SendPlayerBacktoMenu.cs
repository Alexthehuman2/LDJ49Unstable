using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendPlayerBacktoMenu : MonoBehaviour
{
    [SerializeField] private AudioSource death;
    [SerializeField] private Animator deathPanel;

    private void Start()
    {
        death = GetComponent<AudioSource>();
        deathPanel = GameObject.FindGameObjectWithTag("deathTag").GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            Debug.Log("This s till works");
            //+1 to singleton integer, determines how broken the screen is.
            DeathCountSGT.Instance.val++;
            Debug.Log(DeathCountSGT.Instance.val);
            death.Play();
            collision.gameObject.SetActive(false);
            deathPanel.SetBool("playerDead", true);
            StartCoroutine(timerToDeath());
        }
    }
    IEnumerator timerToDeath()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
