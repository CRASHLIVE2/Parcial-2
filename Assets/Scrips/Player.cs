using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables
    public Rigidbody2D Rigidbody1;
    public float Jumpforce = 15;
    public LayerMask Layer_Mask;
    public CapsuleCollider2D ColisionDeCapsula;
    public GameObject MonitoCargando;
    public bool Grounded = false;
    public bool MonitoVisible = false;
    public bool TieneMartillo = false;
    public bool TieneExtintor = false;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D LeftHit = Physics2D.Raycast(transform.position, Vector2.left, 1000, Layer_Mask);
        RaycastHit2D RightHit = Physics2D.Raycast(transform.position, Vector2.right, 1000, Layer_Mask);
        //Movimiento Horizontal
        if (Input.GetKey(KeyCode.D))
        {
            if (RightHit.distance > 1)
            {
                Vector2 CurrentVel = Rigidbody1.velocity;
                CurrentVel.x = +10;
                Rigidbody1.velocity = CurrentVel;
            }

        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (LeftHit.distance > 1)
            {
                Vector2 CurrentVel = Rigidbody1.velocity;
                CurrentVel.x = -10;
                Rigidbody1.velocity = CurrentVel;
            }
        }
        else
        {
            Vector2 CurrentVel = Rigidbody1.velocity;
            CurrentVel.x = 0;
            Rigidbody1.velocity = CurrentVel;
        }
        //Salto
        RaycastHit2D Hit = Physics2D.Raycast(transform.position, Vector2.down, 1000, Layer_Mask);
        if (Hit.distance < 1)
        {
            Grounded = true;
        }
        else
        {
            Grounded = false;
        }
        if (Input.GetKeyDown(KeyCode.W) && Grounded == true)
        {
            Rigidbody1.AddForce(Vector2.up * Jumpforce, ForceMode2D.Impulse);
        }
    }
}
