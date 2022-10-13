using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Scripts.GameSystem
{
    public class PointsManager : MonoBehaviour
    {
        private int points_number;
        private int record_number;
        public Text record_text; 
        [Header("Text with points: ")]
        [Space]
        public Text points_txt;
        public DataManager _dataManager;


        void Start()
        {
            points_number = 0;
            record_number = PlayerPrefs.GetInt("RECORD");
            _dataManager = GetComponent<DataManager>();
            GetPointsUI();
            UpdatePointsOnScreen();
        }

        void GetPointsUI()
        {
            if(points_txt == null)
            {
                GameObject.FindGameObjectWithTag("levelPoints").GetComponent<Text>();
            }
        }

       
        void UpdatePointsOnScreen()
        {
            points_txt.text = points_number.ToString();

        }

        public void ObjectPoints(int points)
        {
            points_number += points;
            UpdatePointsOnScreen();
        }

        public void SavePoints()
        {
          
            _dataManager.SaveAllData(points_number, PlayerPrefs.GetInt("RECORD"));            
        }
        
    }

}