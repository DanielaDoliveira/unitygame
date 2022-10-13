using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.GameSystem;


namespace Scripts.Items
{
    public class Coins : MonoBehaviour
    {
        [Header("Script Points Manager:")]
        [Space]
        public PointsManager _pointsManager;

        [Space]
        [Header("Script Coins Manager:")]
        [Space]
        public CoinsManager _coinsManager;
      

        private void Start()
        {
            _pointsManager = GameObject.Find("GameSystem").GetComponent<PointsManager>();
            _coinsManager = GameObject.Find("CoinsManager").GetComponent<CoinsManager>();
  
        }
       

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                _coinsManager.UpdateCoinsOnGame();
                _pointsManager.ObjectPoints(1);
                Destroy(gameObject);
            }
        }


       
    }

}