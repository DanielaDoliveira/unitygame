using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Enemy
{
    public class EnemyAnimations : MonoBehaviour
    {


        public void EnemyStates(int state)
        {
            GetComponent<Animator>().SetInteger("state", state);
        }

        public void Run()
        {
            Debug.Log("RUN ANIMATION");
            GetComponent<Animator>().SetBool("Run",true);
            Debug.Log("ANIMATED");
        }

        public void Idle()
        {
            Debug.Log("ENTER ON IDLE...");
            GetComponent<Animator>().SetBool("Run", false);
            Debug.Log("Animation finished...");
         
        }

        public void Jump()
        {
            GetComponent<Animator>().SetTrigger("Jump");
        }
        public void Attack()
        {
            GetComponent<Animator>().SetTrigger("Attack");
        }

        public void Death()
        {
            GetComponent<Animator>().SetTrigger("Death");
        }
    }

}


//Esse inimigo persegue o player, mas não ataca, só persegue
//Preciso de  animações de Idle e Run somente

//vou ter outro inimigo que patrulha e que ataca