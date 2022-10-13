using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Network{

[System.Serializable]
public class User
{
    public string username;
    public int record;

    public User() { }

    public User(string username, int record)
    {
        this.username = username;
        this.record = record;
    }

    public string Username
    {
        get { return username; }
        set { username = value; }

    }

    public int Record
    {
        get { return record; }
        set { record = value; }

    }

}



}