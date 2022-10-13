using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
namespace Scripts.Network
{
    /* 
     * 
     * TESTING SCRIPT
     * User u = new User("nameYouWant",9877);
            StartCoroutine(PostRecord(u));
            Debug.Log("Enviado");
            Debug.Log(u);*/

    public class POSTRecord : RestController
    {
        
        private void Start()
        {
            
           
        }
        public IEnumerator PostRecord(User userData, string username,int record)
        {


            string urlNew = string.Format("{0}{1}",WEB_URL,ROUTE_REGISTER_POINTS);
            userData.Username = username;
            userData.Record = record;
            string jsonData = JsonUtility.ToJson(userData);


            using (UnityWebRequest www = UnityWebRequest.Post(urlNew,jsonData))
            {
                www.SetRequestHeader("content-type", "application/json");
                www.SetRequestHeader("Access-Control-Allow-Origin", "*");
                www.uploadHandler.contentType = "application/json";
                www.uploadHandler = new UploadHandlerRaw(System.Text.Encoding.UTF8.GetBytes(jsonData));
                yield return www.SendWebRequest();
                if (www.isNetworkError)
                {
                    Debug.Log(www.error);
                }
                else if (www.isDone)
                {
                    string jsonResult = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
                    Debug.Log(jsonResult);
                }


            }

        }

       


    }

}