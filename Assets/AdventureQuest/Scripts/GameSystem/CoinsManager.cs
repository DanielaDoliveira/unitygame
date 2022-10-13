using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Scripts.GameSystem
{
    public class CoinsManager : MonoBehaviour
    {
        [Header("Object Coins with comp Text: ")]
        [Space]
        public Text coins_text;
        private int coins_number;
 
        private void Start()
        {
            StartDefaultSettings();
            GetCoinsTextReference();
        }

        private void GetCoinsTextReference()
        {
            if(coins_text == null)
            {
                coins_text = GameObject.FindGameObjectWithTag("levelCoins").GetComponent<Text>();
            }
           
        }

      

        public void StartDefaultSettings()
        {
            coins_number = 0;
            coins_text.text = coins_number.ToString();
        }
        public void UpdateCoinsOnGame()
        {
             coins_number += 1;

              coins_text.text = coins_number.ToString();
           
        }

        
    }

}