using UnityEngine;

public class coinSuper : MonoBehaviour
{

    public int pontosCoinSuper;

    private AudioSource coinSuperSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        coinSuperSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            coinSuperSound.Play();
            Destroy(gameObject);
            
            if (gameManager.score == 0)
            {
                gameManager.score = 5;
            }
            else
            {
                gameManager.score += pontosCoinSuper;
            }


        }
    }
}
