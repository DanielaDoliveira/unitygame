using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("TimeToAppear");
    }

    IEnumerator TimeToAppear()
    {
        GetComponent<Animator>().SetBool("Appear", false);
        yield return new WaitForSeconds(10f * Time.deltaTime);
        GetComponent<Animator>().SetBool("Appear", true);
    }
}
