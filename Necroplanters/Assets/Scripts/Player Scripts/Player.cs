using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Obj;

    public float moveSpeed = 5f;
    public float playerScale = 2f;
    public bool isHoldingSeed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalInput * moveSpeed * Time.deltaTime, verticalInput * moveSpeed * Time.deltaTime, 0);

        if (horizontalInput <  0)
        {
            //Player is moving left
            transform.localScale = new Vector3(-playerScale, playerScale, playerScale); //Change player sprite direction
        }
        else if (horizontalInput > 0)
        {
            //Player is moving right
            transform.localScale = new Vector3(playerScale, playerScale, playerScale); //Change player spite direction
        }
    }

    public void PickUpSeed()
    {
        print("seed picked");
        //Child Object 0 is the seedbag
        //If we want to make this better later we can instantiate a random or specific seedbag prefab
        transform.GetChild(0).gameObject.SetActive(true);
        GetComponent<Player>().isHoldingSeed = true;
    }

    public void DropSeed()
    {
        //Child Object 0 is the seedbag
        //If we want to make this better later we can instantiate a random or specific seedbag prefab
        transform.GetChild(0).gameObject.SetActive(false);
        GetComponent<Player>().isHoldingSeed = false;
    }
}
