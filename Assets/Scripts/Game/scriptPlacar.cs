using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptPlacar : MonoBehaviour
{
    public int placar = 0;
    public Text txtPlacar;
    // Start is called before the first frame update
    public void Start()
    {
        PlayerPrefs.SetInt("placar", 0);
    }
    public void incrementar(int soma)
    {
        placar += soma;
        txtPlacar.text = "Sneakers: " + placar;
        PlayerPrefs.SetInt("placar", placar);
    }
}
