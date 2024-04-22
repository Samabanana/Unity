using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeScript : MonoBehaviour
{
    public GameObject player;
    public GameObject dungeonTile;
    public GameObject[,] gameBoard;
    public int row;
    public int column;
    private Player playerCont;
    public bool occupied; //The player can only move if the player is not occupied by a battle or some menu.
    // Start is called before the first frame update
    void Start()
    {
        occupied = false;
        gameBoard = new GameObject[5,5];
        float widthIncrement = Screen.width / 5;
        float lengthIncrement = Screen.height / 5;
        player.transform.position = new Vector3(0,0,0);

        int row = 0;

        while (row < 5) {
            //Instantiate rows
            int column = 0;
            while (column < 5) {
                //For each row, instantiate the columns
                gameBoard[row,column] = Instantiate(dungeonTile, new Vector3(5 + (row * 2), 5 + (column * 2), 0), Quaternion.identity);
                //Have to give each room an event
                column++;
            }
            row++;
        }

        
        
        row = 0;
        column = 0;

        Instantiate(player, gameBoard[column, row].transform.position, Quaternion.identity);
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Move the player
        //This movement is assuming player starts at 0,0
            if(Input.GetKeyDown(KeyCode.UpArrow) && !OutofBounds(row + 1,column))
            {
                row++;
                player.transform.position = gameBoard[column, row].transform.position;
            } 
            else if(Input.GetKeyDown(KeyCode.DownArrow) && !OutofBounds(row - 1,column))
            {
                row--;
                player.transform.position = gameBoard[column, row].transform.position;
            } 
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && !OutofBounds(row,column - 1))
            {
                column--;
                player.transform.position = gameBoard[column, row].transform.position;
            } 
            else if (Input.GetKeyDown(KeyCode.RightArrow) && !OutofBounds(row,column + 1))
            {
                column++;
                player.transform.position = gameBoard[column, row].transform.position;
            }

    }

    public bool OutofBounds(int columnCheck, int rowCheck) {


        int rowBound = gameBoard.GetLength(0);
        int columnBound = gameBoard.GetLength(1);

        //If the index goes negative, don't move
        if(rowCheck < 0 || columnCheck < 0) {
            return true;
        }

        //If the index is more than the length/row of the board, don't move
        if(rowCheck == rowBound || columnCheck == columnBound) {
            return true;
        }

        return false;

    }
}
