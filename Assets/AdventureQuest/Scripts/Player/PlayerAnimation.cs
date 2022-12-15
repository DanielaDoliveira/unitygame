using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Player
{
    public class PlayerAnimation : MonoBehaviour
    {
        private Animator player_animator;


        void Start()
        {
            player_animator = GetComponent<Animator>();
        }
        public void SetWin(bool win)
        {
            player_animator.SetBool("win", win);
        }

        public void SetGroundedAnimation(bool grounded)
        {
            player_animator.SetBool("Grounded", grounded);
        }

        public void SetJumpAnimation()
        {
            player_animator.SetTrigger("Jump");
        }

        public void SetWalkAnimation(bool walk)
        {
            player_animator.SetBool("Walk", walk);
        }
        public void Idle()
        {
            player_animator.Play("Idle");
        }



        public void SetAttackAnimation()
        {

            player_animator.SetTrigger("Attack");
        }
        public void SetState(int run)
        {
            player_animator.SetInteger("State", run);
        }

    }

}