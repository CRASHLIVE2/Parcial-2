using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeEnPeligro : MonoBehaviour
{
 /*  private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("Ganaste");
        }
    }
*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().MonitoCargando.SetActive(true);
            collision.gameObject.GetComponent<Player>().MonitoVisible = true;
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
