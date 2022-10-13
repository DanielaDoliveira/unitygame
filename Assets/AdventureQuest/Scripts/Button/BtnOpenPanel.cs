using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnOpenPanel : MonoBehaviour
{
    private Button button_continue;
   
    public GameObject panel;
    private int points, record;

    bool openp;

    void Start()
    {
        button_continue = GetComponent<Button>();
        panel.SetActive(false);
        button_continue.onClick.AddListener(OpenRegisterPanel);
        points = PlayerPrefs.GetInt("CURRENT_POINTS");
        record = PlayerPrefs.GetInt("RECORD");
    }

    void OpenRegisterPanel()
    {
       
        
        BtnAction(openp);
        if (openp)
        {
            Debug.Log("----OPENED-----");
         

        }
        else if(!openp)
        {
            Debug.Log("----CLOSED-----");
        }
        
       
    }


    bool BtnAction(bool open)
    {
       
        if(points >= record)
        {
            Debug.Log("----OPEN-----");
            panel.SetActive(true);
            return open = true;
        }
        else
        {
            SceneManager.LoadScene(0);
            return open = false;
           
        }
    }
}
