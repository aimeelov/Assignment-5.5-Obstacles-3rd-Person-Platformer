using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    //counter for the remaining collectables in the scene
    public int counter;
    
    //The prefab that will be instantiated
    public GameObject bonusObject;


    // Start is called before the first frame update
    void Start()
    {
        if(bonusObject.CompareTag("Pick Up"))
            counter = GameObject.FindGameObjectsWithTag("Pick Up").Length;
        

        if(bonusObject.CompareTag("Coin"))
            counter = GameObject.FindGameObjectsWithTag("Coin").Length;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup()
    {
        counter --;

        if(counter == 0)
            SpawnBonus();


    }


    void SpawnBonus()
    {
        //Instantiate our prefab!
        GameObject.Instantiate(bonusObject, transform);

    }
} 

