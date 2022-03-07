using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour
{
    public Text Timertext;
    public float TiempoMax = 60;
    public float CurrentTime = 30;
    public static MissionManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = TiempoMax;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= Time.deltaTime;
        Timertext.text = Mathf.RoundToInt(CurrentTime).ToString();
        if (CurrentTime <= 0)
        {
            Debug.Log("Perdiste");
            SceneManager.LoadScene("Derrota");
        }
    }
}
