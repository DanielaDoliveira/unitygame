using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.GameSystem;
using Scripts.Items;

namespace Scripts.Player
{
    public class PlayerCollisions : MonoBehaviour
    {

        public GameRule _gameRule;
        public ChestAnim _chestAnim;
        public PointsManager _pointsManager;
       
        void Start()
        {
            GameRuleComponent();
            PointsManagerComponent();
            ChestAnimComponent();
        }

        void GameRuleComponent()
        {
            if (_gameRule == null)
            {
                _gameRule = GameObject.Find("GameSystem").GetComponent<GameRule>();
            }
        }

        void PointsManagerComponent()
        {
            if (_pointsManager == null)
            {
                _pointsManager = GameObject.Find("GameSystem").GetComponent<PointsManager>();
            }
        }

      

        void ChestAnimComponent()
        {
            if(_chestAnim == null)
            {
                _chestAnim = GameObject.Find("Chest").GetComponent<ChestAnim>();
            }
        }
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.layer == 4)
            {
                Destroy(gameObject);
                _gameRule.LoadRepeatCurrentlyScene();
            }

            if(col.gameObject.layer == 7)
            {
                LoadData();
                
               
            }
        }

        public void LoadData()
        {
            _pointsManager.SavePoints();
            _chestAnim.OpenChest(); 
        }

     




    }

}