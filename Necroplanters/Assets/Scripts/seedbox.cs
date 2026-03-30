using UnityEngine;

public class seedbox : MonoBehaviour
{
    public GameObject player;
    public float distanceToGrab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            float distanceToSeedBox = Vector3.Distance(player.transform.position, transform.position);
            if(distanceToSeedBox <= distanceToGrab )
            {
                //If the player is holding a seed then put it back
                if (player.GetComponent<Player>().isHoldingSeed)
                {
                    player.GetComponent<Player>().DropSeed();
                }
                //Otherwise pick up a seed
                else
                {
                    player.GetComponent<Player>().PickUpSeed();
                }
                
            }
        }
    }
}
