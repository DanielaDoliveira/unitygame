using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMap : MonoBehaviour
{

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject uiEnter;


    private void Start()
    {
        uiEnter.SetActive(false);
      
    }

    private void FixedUpdate()
    {
      
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("level"))
        {
            uiEnter.SetActive(true);
            
        }

        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("level"))
        {
            uiEnter.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                var scene = SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene(scene);
            }

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        uiEnter.SetActive(false);



    }
}
