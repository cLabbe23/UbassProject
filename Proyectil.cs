using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour {
    public float rapidez = 1;
    public int danio = 1;



    public Proyectil(float rapidez)
    {
        this.rapidez = rapidez;
    }
    public int getDanio()
    {
        return this.danio;
    }
    public void SetDanio(int danio)
    {
        this.danio = danio;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var choque = collision.gameObject;
        var vida = choque.GetComponent<Vida>();
        if (vida != null)
        {
            vida.recibeDanio(1);
        }
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start() {
    
   }
// Update is called once per frame

 void Update () {
		
	
}
}