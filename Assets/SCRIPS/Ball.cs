using UnityEngine;

public class Ball : MonoBehaviour
{

    public float lives = 2f;

    Vector2 startPosition;

    void Start()
    {
       startPosition = transform.position;
        ResetLevel();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DeadZone"))
        {
            Debug.Log("Game Over");
            lives--;

            if (lives <= 0)
            {
                ResetLevel();
            }
        }
    }

    public void ResetLevel()
    {
        transform.position = startPosition;
    }
}
