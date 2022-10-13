using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.GameSystem;
public class DeleteRegister : MonoBehaviour
{
    private DataManager dataManager;
    void Start()
    {
        dataManager = GetComponent<DataManager>();
        dataManager.DeleteKeyRecord();
    }


}
