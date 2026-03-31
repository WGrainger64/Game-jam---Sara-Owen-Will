using UnityEngine;

public class gardenSlot : MonoBehaviour
{
    public GameObject ghostPlant;
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
                if (collision.gameObject.GetComponent<Player>().isHoldingSeed)
                {
                    //Instantiate a plant here with this slot as a parent
                    GameObject ghostPlantInst = Instantiate(ghostPlant, this.transform);
                    //Set its local pos to 0
                    ghostPlantInst.transform.localPosition = new Vector3(0, 0, 0);
                    collision.gameObject.GetComponent<Player>().DropSeed();
                }
            
             }
        }
       
    }
}
