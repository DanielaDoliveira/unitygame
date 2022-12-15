using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Scripts.Enemy
{
    
    public class EnemyLife : MonoBehaviour
    {

        SkinnedMeshRenderer col;
        [SerializeField] int life = 4;

        public int impulse = 2;
        public void TakeDmg()
        {
            life -= 1;

        }

        public void ColSword()
        {
          
        }
        public void OnTriggerEnter2D(Collider2D collision)
        {
           
            if (collision.gameObject.layer == 12)
            {
                Debug.Log("ENTER trig");
                TakeDmg();
               
                StartCoroutine("DMGCOLOR");
                if (life <= 0)
                {
                    Debug.Log("DIE trig");
                    Destroy(gameObject);
                }
            }
        }

        public void OnCollisionEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("attack"))
            {
                Debug.Log("ENTER COL");
                TakeDmg();
               
                if (life <= 0)
                {
                    GetComponent<Animator>().SetTrigger("Death");
                }
            }
        }

        IEnumerator DMGCOLOR()
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            yield return new WaitForSeconds(1);
            GetComponent<SpriteRenderer>().color = Color.white;
        }

    }

}