using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 Responsável por controlar a barra de vida 
 */
namespace Scripts.UI.PlayerAttributes
{
    public class PlayerLife : MonoBehaviour
    {
        public Slider life_bar;

      
        void Start()
        {
            if (life_bar == null)
            {
                life_bar = GameObject.FindGameObjectWithTag("lifeUI").GetComponent<Slider>();
            }
        }


        void Update()
        {
            
        }

      public  void TakeDamage(int dmg)
        {
            life_bar.value = life_bar.value - dmg;
            GameOver();
        }

       public void GainLife(int lf)
        {
            life_bar.value = life_bar.value + lf;

        }

      public  void GameOver()
        {
            if (life_bar.value < 0 || life_bar.value == 0)
            {
                
                SceneManager.LoadScene("GameOver");
            }
        }
    }

}