using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Obj;

    public float moveSpeed = 5f;
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
            transform.localScale = new Vector3(-1f, 1f, 1f); //Change player sprite direction
        }
        else if (horizontalInput > 0)
        {
            //Player is moving right
            transform.localScale = new Vector3(1f, 1f, 1f); //Change player spite direction
        }
    }
}
