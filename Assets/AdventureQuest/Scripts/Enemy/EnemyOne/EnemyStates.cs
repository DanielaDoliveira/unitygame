using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Enemy
{
  
    public class EnemyStates : MonoBehaviour
    {

       [Header("Player Transform: ")][Space]
       public Transform player;

       [SerializeField] private float agro_range;

       [SerializeField] private float move_speed;

       [SerializeField]private Rigidbody2D rb_2d;

        private EnemyAnimations _enemyAnimations;
        public Transform vision;

        
        
        void Start()
        {
           
            _enemyAnimations = GetComponentInChildren<EnemyAnimations>();
            GetPlayer();
           
        }

        void GetPlayer()
        {
            
            if(player == null)
            {
                player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            }
        }



        
        void Update()
        {
            
        }

        
     public   void EnemyDistance()
        {
         

            if(CanSeePlayer(agro_range))
            {
                ChasePlayer();
            }
            else
            {
                StopChasingPlayer();
            }

        }

      public  void ChasePlayer()
        {

         //   _enemyAnimations.Run();
            if (transform.position.x > player.position.x)
            {
                Debug.Log("Move left <-");
                // rb_2d.velocity = new Vector2(-1 * move_speed * Time.deltaTime, 0);
                transform.position += Vector3.MoveTowards(transform.position, player.position, 0.5f);
            }
            if (transform.position.x < player.position.x)
            {
                Debug.Log("Move Right ->");
                transform.position += Vector3.right * move_speed * Time.deltaTime;
            }


            else
            {
                
                rb_2d.velocity = new Vector2(+move_speed*Time.deltaTime, 0);
                transform.localScale = new Vector2(1, 1);

            }

           

        }

       public void StopChasingPlayer()
        {
//_enemyAnimations.Idle();
            rb_2d.velocity = Vector2.zero;
           

        }


        bool CanSeePlayer(float distance)
        {
            bool can_see = false;
           
            Vector2 end_pos = vision.position + Vector3.right * distance;
            //  RaycastHit2D hit =  Physics2D.Linecast(vision.position, end_pos,1<<LayerMask.NameToLayer("Action"));
            RaycastHit2D hit = Physics2D.CircleCast(vision.position, 10f, end_pos, 1 << LayerMask.NameToLayer("Action"));
         

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.CompareTag("Player"))
                {
                    can_see = true;
                }
            }
            else
            {
                can_see = false;
            }

            return can_see;
        }
    }

}