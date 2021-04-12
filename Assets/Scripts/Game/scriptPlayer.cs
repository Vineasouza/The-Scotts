using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlayer : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel = 1;
    private bool direita = true;
    public float pulo = 200;
    private bool chao = true;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag != "Sneaker")
        {
            transform.parent = collision.collider.transform;
            chao = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        transform.parent = null;
        chao = false;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rbd.velocity = new Vector2(x * vel, rbd.velocity.y);

        if (direita && x < 0 || !direita && x > 0)
        {
            transform.Rotate(new Vector2(0, 180));
            direita = !direita;
        }


        if (Input.GetKeyDown(KeyCode.Space) && chao)
        {
            rbd.AddForce(new Vector2(0, pulo));
        }
    }
}
