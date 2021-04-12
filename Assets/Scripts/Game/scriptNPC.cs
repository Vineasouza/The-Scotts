using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptNPC : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel = 0.008f;
    private float walk = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, vel);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "parede" || collision.collider.tag == "Sneaker" || collision.collider.tag == "Espinho")
        {
            transform.Rotate(new Vector2(0, 180));
            walk = -walk;
        }

        if(collision.collider.tag == "Player")
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }    
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.tag == "Player")
        {
            GameObject gamePlacar = GameObject.Find("controlePlacar");
            scriptPlacar script = gamePlacar.GetComponent<scriptPlacar>();
            script.incrementar(5);
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(this.transform.position.x + walk, transform.position.y) * vel;
    }
}
