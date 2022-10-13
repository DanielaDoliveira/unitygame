using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Network
{
    public class RestInstance : MonoBehaviour
    {
        private static RestInstance instance;
        void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }
            else
            {

                Destroy(instance);
            }

            DontDestroyOnLoad(instance);
        }

       
    }

}