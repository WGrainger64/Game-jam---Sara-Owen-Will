using UnityEngine;

public class sprout : MonoBehaviour
{
    //Put the prefab for whatever plant you want in this var
    public GameObject plantType;
    float sproutStartTime;
    public float minutesToGrow;
    void Awake()
    {
        sproutStartTime = 0f;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //every 10 seconds a minute will pass in game
        sproutStartTime += Time.deltaTime;

        if (sproutStartTime >= minutesToGrow)
        {
            PlantGrowth();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlantGrowth()
    {
        //Replace sprout with an instantiation of whatever plant type it is
    }
}
