using UnityEngine;

public class camera : MonoBehaviour

{
    private GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        player = GameObject.Find("player");
        
    }

    // Update is called once per frame
    void Update()
    {

        if (player.transform.position.x >= transform.position.x)
        {
            transform.position = new Vector3(player.transform.position.x, 0, -10);
        }
        
    }
}
