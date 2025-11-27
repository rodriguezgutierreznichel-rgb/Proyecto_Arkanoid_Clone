using UnityEngine;
using TMPro;
public class Ball : MonoBehaviour
{

    public Rigidbody fisicaPelota;

    public float velocidadPelota = 800; 

   

    private Vector2 directionPelota;

   

    void Start()
    {
        directionPelota.x = Random.Range(-1f, 1f);

        directionPelota.y = 1;

        fisicaPelota.AddForce(directionPelota * velocidadPelota);
    }


    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
            directionPelota.x = Random.Range(-1f, 1f);
            directionPelota.y = 1;
            fisicaPelota.AddForce(directionPelota * velocidadPelota);
            
            
        }
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            directionPelota.x = Random.Range(-1f, 1f);
            directionPelota.y = -1;
            fisicaPelota.AddForce(directionPelota * velocidadPelota);


        }
        else
        {
            directionPelota.x = Random.Range(-1f, 1f);
            directionPelota.y = 0;
            fisicaPelota.AddForce(directionPelota * velocidadPelota);
        }

    }



}
