using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OkBtn : MonoBehaviour
{
    // Development Scripts

    public GameObject panel;
    void Start()
    {
        panel.SetActive(true);
        GetComponent<Button>().onClick.AddListener(Ok);
    }

    void Ok()
    {
        panel.SetActive(false);
    }
   
}
