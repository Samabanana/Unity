using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Script for the player
    private InitializeScript script;
    //Variables
    public Vector2 playerPos; //Establish the player's position
    

    // Start is called before the first frame update
    void Start()
    {
        playerPos = new Vector2(script.row, script.column);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
