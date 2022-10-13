using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Player
{
    public class PlayerSprite : MonoBehaviour
    {
        public PlayerController _playerController;

        private void Start()
        {
            _playerController = GetComponent<PlayerController>();
        }

        private void Update()
        {
            Flip();
        }

        void Flip()
        {
            if (_playerController.Move_Input > 0)
            {
                FlipFront();
            }

            else if(_playerController.Move_Input < 0)
            {
                FlipBack();
            }

        }

        void FlipFront()
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        void FlipBack()
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

    }
}
