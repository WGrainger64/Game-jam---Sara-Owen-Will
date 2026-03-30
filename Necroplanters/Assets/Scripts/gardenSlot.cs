using UnityEngine;

public class gardenSlot : MonoBehaviour
{
    public bool isColliding = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        //If there is a collision with a player
        if (collision.gameObject.CompareTag("Player"))
        {
             if (Input.GetKey(KeyCode.Return))
             {
                print("clicked");
                if (collision.gameObject.GetComponent<Player>().isHoldingSeed)
                {
                    //Instantiate a plant here
                    print($"planted in garden at location {transform.position}");
                    collision.gameObject.GetComponent<Player>().DropSeed();
                }
            
             }
        }
       
    }
}
