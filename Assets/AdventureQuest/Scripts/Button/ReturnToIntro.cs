using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Scripts.Network;
public class ReturnToIntro : MonoBehaviour
{

    private Button button_continue;
    public TMP_InputField inputField;
    public POSTRecord _postRecord;
    void Start()
    {
        button_continue = GetComponent<Button>();
       
        button_continue.onClick.AddListener(RestartGame);
   
    }

    void RestartGame()
    {
        SendToServer();
        SceneManager.LoadScene(0);
    }

   public void SendToServer()
    {
        if(inputField.text != null || inputField.text != "")
        {
        
                string user_name = inputField.text;
                User u = new User();
                StartCoroutine(_postRecord.PostRecord(u, user_name, PlayerPrefs.GetInt("RECORD")));
            
        }
        else
        {
            Debug.Log("Invalid format");
        }
       
 
    }
    
}




