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
         // Move the player
        //This movement is assuming player starts at 0,0
           /* if(Input.GetKeyDown(KeyCode.UpArrow) && !script.OutofBounds(script.row + 1, script.column))
            {
                Debug.Log("moving");
                script.row++;
                this.transform.position = script.gameBoard[script.column, script.row].transform.position;
            } 
            else if(Input.GetKeyDown(KeyCode.DownArrow) && !script.OutofBounds(script.row - 1, script.column))
            {
                script.row--;
                this.transform.position = script.gameBoard[script.column, script.row].transform.position;
            } 
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && !script.OutofBounds(script.row, script.column - 1))
            {
                script.column--;
                this.transform.position = script.gameBoard[script.column, script.row].transform.position;
            } 
            else if (Input.GetKeyDown(KeyCode.RightArrow) && !script.OutofBounds(script.row, script.column + 1))
            {
                script.column++;
                this.transform.position = script.gameBoard[script.column, script.row].transform.position;
            } */
    }
}
