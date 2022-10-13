using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.GameSystem;
using Scripts.Player;
namespace Scripts.Items
{

    public class ChestAnim : MonoBehaviour
    {
        public GameRule _gameRule;
      
        public PlayerAnimation _playerAnimation;
        private void Start()
        {
            GetGameRule();
           
            GetPlayerAnimation();
        }
       private void GetGameRule()
        {
            if (_gameRule == null)
            {
                _gameRule = GameObject.Find("GameSystem").GetComponent<GameRule>();
            }
        }

       
        private void GetPlayerAnimation()
        {
            if (_playerAnimation == null)
            {
                _playerAnimation = GameObject.FindWithTag("Player").GetComponent<PlayerAnimation>();
            }
        }
        public void OpenChest()
        {
            _gameRule.BlockPlayerMovements();
            _playerAnimation.Idle();
            GetComponent<Animator>().SetTrigger("open");
        }

        public void AnimEventCallVictoryScene()
        {
            _gameRule.LoadVictoryScene();

        }

    }
}
