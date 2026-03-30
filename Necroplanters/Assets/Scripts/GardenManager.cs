using UnityEngine;
using UnityEngine.Rendering;
using System;
using System.Collections.Generic;

public class GardenManager : MonoBehaviour
{
    public static GardenManager Instance { get; set; }
    public List<GameObject> gardenSlots;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //If the player pushes enter and they are holding seeds then get rid of the seeds and plant a new plant
        if (Input.GetKeyDown(KeyCode.Return))
        {
           foreach (GameObject gardenSlot in gardenSlots)
           {
                //Check if the player is standing over a garden space

            }
        }
         
    }
}
