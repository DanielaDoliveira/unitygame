using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Layer;


namespace Scripts.Player
{
    [RequireComponent(typeof(PlayerAnimation))]
    public class PlayerController : MonoBehaviour
    {

        private Rigidbody2D player_rb;
        private PlayerAnimation player_anim;

        
        private float move_input;

        [Header("Jump Height")]
        [Space]
        public float jump_force;


        [Header("Movement Speed")]
        [Space]
        public float speed;

        [Header("Jump Validation")]
        [Space]
        private bool is_Grounded;
        public Transform feet_pos;
        private float check_radius = 0.1f;
        public LayerMask what_is_ground;
        public bool is_Jumping = true;
        public float jump_time;
        private GroundChecker _groundChecker;
        private float jump_time_counter;

        public bool isAttacking = false;
        private bool win_Game = false;

        void Start()
        {
            player_rb = GetComponent<Rigidbody2D>();
            player_anim = GetComponent<PlayerAnimation>();
            _groundChecker = GetComponent<GroundChecker>();
          
           
        }



        void Update()
        {
            is_Grounded = _groundChecker.CheckGroundLayer(feet_pos, check_radius, what_is_ground);
            player_anim.SetWin(win_Game);
            player_anim.SetGroundedAnimation(is_Grounded);
            InputJump();
            JumpValidation();
            MovementAnimation();
            InputAttack();
            WinGameCheck();
          
            
        }

      private void WinGameCheck()
        {
            if (win_Game)
            {
                player_rb.velocity = Vector2.zero;
            }
        }
        private void FixedUpdate()
        {
            Movement();
          
        }

        #region #### Getters and Setters ####
        public float Move_Input
        {
            get{
                return move_input;
            }
            set{
                move_input = value;
            }
        }

        public bool Win_game
        {
            get
            {
                return win_Game;
            }
            set
            {
                win_Game = value;
            }
        }

        #endregion


        
        void Movement()
        {
            if (isAttacking || win_Game)
            {
                
                return;
            }
            else
            {
                move_input = Input.GetAxisRaw("Horizontal");
                player_rb.velocity = new Vector2(move_input * speed, player_rb.velocity.y);
            }
        }
       
       void MovementAnimation()
        {
            if (move_input !=0)
            {
                player_anim.SetState(1);
            }
            else if(move_input == 0)
            {
                player_anim.SetState(0);
            }
          
        }
        void InputJump()
        {
         
            if (is_Grounded && Input.GetKeyDown(KeyCode.Space) && !win_Game)
            {
                is_Jumping = true;
                player_anim.SetJumpAnimation();
                jump_time_counter = jump_time;
                player_rb.velocity = Vector2.up * jump_force;
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                is_Jumping = false;
            }



        }

        void InputAttack()
        {
            if (Input.GetKeyDown(KeyCode.Z) && !isAttacking && !win_Game)
            {
                isAttacking = true;
                player_anim.SetAttackAnimation();
            }
            
        }

        public void FinishAttack()
        {
            isAttacking = false;
        }
     
        void JumpValidation()
        {
            if (jump_time_counter > 0)

            {
                player_rb.velocity = Vector2.up * jump_force;
                jump_time_counter -= Time.deltaTime;
            }

        }


    }
}


