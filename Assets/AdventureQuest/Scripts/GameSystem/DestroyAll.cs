using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.GameSystem
{
    public class DestroyAll : MonoBehaviour
    {
        public GameObject gameSystem;
        public bool destroy_all;
        void Awake()
        {
            gameSystem = GameObject.Find("GameSystem").GetComponent<GameObject>();
            if (gameSystem != null)
            {
                destroy_all = true;
                
            }
            else
            {
                destroy_all = false;
                return;
            }
        }

        public bool DestroyGameSys(bool destroy)
        {
            if (gameSystem != null)
            {
                destroy_all = true;

            }
            else
            {
                destroy_all = false;
                
            }



            return destroy;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}