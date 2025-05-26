using UnityEngine;

public class coin : MonoBehaviour
{
    public int pontosCoin;
    
    private AudioSource coinSound;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        coinSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            coinSound.Play();
            Destroy(gameObject);
            
            if (gameManager.score == 0)
            {
                gameManager.score = 1;
            }
            else
            { 
                gameManager.score += pontosCoin;
            }
        }
        
    }
}
