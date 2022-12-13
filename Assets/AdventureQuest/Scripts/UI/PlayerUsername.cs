using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUsername : MonoBehaviour
{

   public GameObject userName;
    public GameObject player;
    public Rigidbody2D rb;
    void Start()
    {
       
    }

   
    void Update()
    {
        if(player.transform.rotation.y == 0)
        {
            transform.localScale = new Vector3(transform.localScale.x, 1, 1);
        }
  
        if(player.transform.rotation.y == -180)
        {
            transform.localScale = new Vector3(-transform.localScale.x, 1, 1);
        }
    }
}
