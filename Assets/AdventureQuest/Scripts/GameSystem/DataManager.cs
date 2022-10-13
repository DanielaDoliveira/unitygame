using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Scripts.Network;
using TMPro;
namespace Scripts.GameSystem
{

    public class DataManager : MonoBehaviour
    {


     

     
        #region ---- Capture all Data Keys ----
        public void GetAllData(Text points, Text record,string tag_points, string tag_record)
        {
            //
            points = GameObject.FindWithTag(tag_points).GetComponent<Text>();
            record = GameObject.FindWithTag(tag_record).GetComponent<Text>();

            //Get Registry
            points.text = PlayerPrefs.GetInt("CURRENT_POINTS").ToString();
            record.text = PlayerPrefs.GetInt("RECORD").ToString();
        }

        #endregion

      

        #region ---- Set all Data keys ----
        public void SaveAllData(int current_points, int record)
        {
         
            PlayerPrefs.SetInt("CURRENT_POINTS", current_points);
            if (current_points > record)
            {
                PlayerPrefs.SetInt("RECORD", current_points);
            

            }
        }


      
        #endregion


        #region Environment

        public void DeleteAll()
        {
            PlayerPrefs.DeleteAll();
        }

        public void DeleteKeyPoints()
        {
            PlayerPrefs.DeleteKey("CURRENT_POINTS");
        }

        public void DeleteKeyRecord()
        {
            PlayerPrefs.DeleteKey("RECORD");
        }
        #endregion


        public void StartDefault()
        {
          
            PlayerPrefs.SetInt("CURRENT_POINTS", 0);
        }



    }

}