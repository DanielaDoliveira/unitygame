using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.SplashToIntro
{
    public class SplashToIntro : MonoBehaviour
    {
        public float time;
      
        void Start()
        {
            StartCoroutine(TimeToNextScene());
        }

       
        void Update()
        {

        }

        IEnumerator TimeToNextScene()
        {
            yield return new WaitForSeconds(time);
            CallNextScene();
        }

        public void CallNextScene()
        {
            var next_scene = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(next_scene);
        }
    }

}