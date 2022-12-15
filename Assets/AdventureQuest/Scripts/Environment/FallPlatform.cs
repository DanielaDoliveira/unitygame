using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatform : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rb;
    public GameObject[] particles;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
        Destroy(gameObject, 10f);
    }

    public IEnumerator Fall()
    {
       
        yield return new WaitForSeconds(10 * Time.deltaTime);
        rb.isKinematic = false;
        Destroy(particles[0]);
        Destroy(particles[1]);
    }
}
