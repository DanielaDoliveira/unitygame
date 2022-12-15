using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Enemy
{
  
    public class EnemyVision : MonoBehaviour
    {
        public EnemyStates _enemyStates;


        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.CompareTag("Player")){

                Debug.Log("DETECTED");
                _enemyStates.ChasePlayer();
            }
        }
        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {

                Debug.Log("DETECTED");
                _enemyStates.ChasePlayer();
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            Debug.Log("NOT DETECTED...");
            _enemyStates.StopChasingPlayer();
        }


    }

}