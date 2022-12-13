using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts.UI.PlayerAttributes
{
    public class PlayerEnergy : MonoBehaviour
    {
        public Slider energy_bar;

        void Start()
        {
            if(energy_bar == null)
            {
                energy_bar = GameObject.FindGameObjectWithTag("energyUI").GetComponent<Slider>();
            }
           
        }

       
        
      public  void UseEnergy()
        {
            energy_bar.value -= 5;
        }


       public void GainEnergy(int e)
        {
            energy_bar.value = energy_bar.value + e;

        }

      public  void PowerUp()
        {
            
        }
    }
}
