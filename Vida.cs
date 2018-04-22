using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour {
    public const int vidamaxima = 3;
    public int vidaActual = vidamaxima;

    public void recibeDanio(int danio)
    {
        vidaActual -= danio;
        if(vidaActual <= 0)
        {
            vidaActual = 0;
            Debug.Log("Mision finalizada.");
        }
    }
    

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
