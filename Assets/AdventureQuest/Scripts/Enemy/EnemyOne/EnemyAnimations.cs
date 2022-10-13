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
            GetComponent<Animator>().Play("Start Run");
        }

        public void Idle()
        {
            GetComponent<Animator>().Play("Idle 2");
        }
    }

}