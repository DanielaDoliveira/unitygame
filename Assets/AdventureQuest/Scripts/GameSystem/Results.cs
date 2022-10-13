using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts.GameSystem
{
    public class Results : MonoBehaviour
    {
        private Text points_txt, record_txt;
        public DataManager _dataManager;
        void Awake()
        {
            _dataManager.GetAllData(points_txt, record_txt, "points", "record");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}