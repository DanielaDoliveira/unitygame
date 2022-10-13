using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Scripts.Player;

namespace Scripts.GameSystem
{
    public class GameRule : MonoBehaviour
    {

        private float time_transition = 2f;
        public PlayerController _playerController;
     
 
      
      
        private void Start()
        {
            GetPlayerController();
           
        }



        private void Update()
        {
          

        
        }

        
        
        private int SceneIndexVictory()
        {
            return 2;
        }

        private int SceneIndexGO()
        {
            return 3;
        }


 

       
        private void GetPlayerController()
        {
            if (_playerController == null)
            {
                _playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
            }
        }
    
  
    public void LoadGameOverScene()
        {
            SceneManager.LoadScene("GameOver");
        }

        public void LoadRepeatCurrentlyScene()
        {
            StartCoroutine(RepeatCurrentlyScene());
        }

       

        public void LoadVictoryScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }


     

        private IEnumerator RepeatCurrentlyScene()
        {
           
            yield return new WaitForSeconds(time_transition);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void BlockPlayerMovements()
        {
            _playerController.Win_game = true;
        }



    }

}