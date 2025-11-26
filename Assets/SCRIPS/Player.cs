using JetBrains.Annotations;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody fisicaPlayer; 

    private float posicionPlayer; //Posicion inicial del objeto.

    public float velocidadPlayer = 25; //Velocidad del obejto.

    private Vector2 directionPlayer; //Direccion que se movera el objeto.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) //Si presiono > o la D...
        {
            directionPlayer = Vector2.right; //El objeto se mueve a la derecha.
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) //Si presiono < o la A...
        {
            directionPlayer = Vector2.left; //El objeto se mueve a la izquierda.
        }
        else if (posicionPlayer == 0) //Si el valor de inicio es 0, es decir, si no cambia su dirección...
        {
            directionPlayer = Vector2.zero; //El objeto no se mueve.
        }

        fisicaPlayer.AddForce(directionPlayer * velocidadPlayer * Time.deltaTime * 100); //Ejerce la fuerza para mover el objeto.
        

      
    }

}
