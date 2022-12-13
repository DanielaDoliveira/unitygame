using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
namespace Scripts.GameSystem
{
    public class CoinsManager : MonoBehaviour
    {
        [Header("Object Coins with comp Text: ")]
        [Space]
        public TextMeshProUGUI coins_text;
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
                coins_text = GameObject.FindGameObjectWithTag("levelCoins").GetComponent<TextMeshProUGUI>();
            }
           
        }

      

        public void StartDefaultSettings()
        {
            coins_number = 0;
            coins_text.SetText(coins_number.ToString());           
        }
        public void UpdateCoinsOnGame()
        {
             coins_number += 1;

            coins_text.SetText(coins_number.ToString());
           
        }

        public void SpendCoins(int spend)
        {
            coins_number -= spend;
            coins_text.SetText(coins_number.ToString());
        }

        
    }

}