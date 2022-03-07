using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CajaDeVictoria : MonoBehaviour
{
    public GameObject MonitoSalvado;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            if (collision.gameObject.GetComponent<Player>().MonitoVisible == true)
            {
                Debug.Log("Ganaste");
                collision.gameObject.GetComponent<Player>().MonitoVisible = false;
                collision.gameObject.GetComponent<Player>().MonitoCargando.SetActive(false);
                MonitoSalvado.SetActive(true);
                SceneManager.LoadScene("Victoria");
            }
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
