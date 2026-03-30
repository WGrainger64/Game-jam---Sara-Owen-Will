using TMPro;
using UnityEngine;

public class Day_Night_Script : MonoBehaviour
{
    public float currentSecond = 0;
    public float currentMinute = 0;
    public float currentHour = 1;
    [SerializeField]public TextMeshProUGUI currentTimeUI;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTimeUI.text = $"{currentHour}:{currentMinute}";
    }

    // Update is called once per frame
    void Update()
    {
        //every 10 seconds a minute will pass in game
        currentSecond += Time.deltaTime;

        //Classic time stuff
        if (currentSecond >= 10)
        {
            currentMinute++;
            currentSecond = 0;
        }

        if (currentMinute >= 60)
        {
            currentHour++;
            currentMinute = 0;
        }

        if (currentHour >= 12)
        {
            currentHour = 1;
        }
        //Gives me an error unless i specify not null
        if (currentTimeUI != null)
        {
            //If the minute is less than 10 we need to add a 0 behind it to give it that iconic clock feel
            if (currentMinute < 10)
            {
                currentTimeUI.text = $"{currentHour}:0{currentMinute}";
            }
            else
            {
                currentTimeUI.text = $"{currentHour}:{currentMinute}";
            }
            
        }
    }
}
