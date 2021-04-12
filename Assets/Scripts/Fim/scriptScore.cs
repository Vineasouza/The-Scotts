using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptScore : MonoBehaviour
{
    public Text txtScore;
    private int resultado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        resultado = PlayerPrefs.GetInt("placar");
        txtScore.text = "Score: " + resultado;
    }
}
