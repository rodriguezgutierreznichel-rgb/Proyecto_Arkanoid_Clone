using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody fisicaPelota;

    public float velocidadPelota = 300; 

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

  

   
}
