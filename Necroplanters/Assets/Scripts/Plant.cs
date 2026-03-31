using UnityEngine;

public class Plant : MonoBehaviour
{
    //General Plant Script
    public int health;
    public float minutesToGrow;
    public bool isDead;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Method for the plant to take damage and potentially die
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 0)
        {
            //Plant dead
            isDead = true;  
        }
        else
        {
            //plant took damage
            //Do some kinda dmg animation
        }
    }
}
