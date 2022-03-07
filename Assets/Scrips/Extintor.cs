using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extintor : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().TieneExtintor = true;
            Debug.Log("Ahora tienes un Extintor");
            MissionManager.instance.CurrentTime += 30;
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
