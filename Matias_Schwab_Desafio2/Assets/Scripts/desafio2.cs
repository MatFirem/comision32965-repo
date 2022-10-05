using UnityEngine;

public class desafio2 : MonoBehaviour
{
    public float vida = 100;
    public float velocidad = 0.1f;
    public Vector3 direccion;
   

    void Start()
    {
        Debug.Log(vida);
       
         
    }

    void Update()
    {
        transform.position += direccion * velocidad * Time.deltaTime;
        CurarJugador();
        HerirJugador();

        Debug.Log(vida);
        Debug.Log("hola");
             
    }

    void CurarJugador()
    {
        vida = vida + 1 * Time.deltaTime;
    }
    void HerirJugador()
    {
        vida = vida - 5 * Time.deltaTime;
    }
   
}
