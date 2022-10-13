using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Layer
{
    public class GroundChecker : MonoBehaviour
    {
      
        private bool isGrounded;


        public bool CheckGroundLayer(Transform feetPos, float checkRadius, LayerMask whatIsGround)
        {
            isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
            return isGrounded;
        }



       

      
    }
}
