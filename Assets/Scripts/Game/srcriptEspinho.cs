using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class srcriptEspinho : MonoBehaviour
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
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
