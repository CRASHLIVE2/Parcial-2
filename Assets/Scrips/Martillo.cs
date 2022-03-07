using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Martillo : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().TieneMartillo = true;
            Debug.Log("Ahora tienes un martillo");
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
