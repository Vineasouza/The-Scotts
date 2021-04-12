using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlat : MonoBehaviour
{

    private Vector2 posInicial;
    private float cont;
    public float deslocamento = 1.5f;
    public float raio = 0;
    public float largura = 0;
    public float altura = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
        cont = 0;
        deslocamento = Random.Range(1.0f, 2.0f);
        //altura = Random.Range(1, 4);
        //largura = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        cont += deslocamento * Time.deltaTime;

        float posX = Mathf.Sin(cont) * largura;
        float posY = Mathf.Cos(cont) * altura;

        transform.position = new Vector2(posInicial.x + posX, posInicial.y + posY);

        if (cont > 2 * Mathf.PI)
            cont = 0;
    }
}
