using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptSneakerPlus : MonoBehaviour
{   
       private Rigidbody2D rbd;
    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject gamePlacar = GameObject.Find("controlePlacar");
            scriptPlacar script = gamePlacar.GetComponent<scriptPlacar>();
            script.incrementar(10);
            Destroy(gameObject);
        }

        if (collision.collider.tag != "Player")
        {
            transform.parent = collision.collider.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag != "Player")
        {
            transform.parent = null;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
