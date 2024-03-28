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
    // Start is called before the first frame update
    void Start()
    {
        
        gameBoard = new GameObject[5,5];
        float widthIncrement = Screen.width / 5;
        float lengthIncrement = Screen.height / 5;
        Debug.Log(Screen.width);
        player.transform.position = new Vector3(0,0,0);

        int row = 0;

        while (row < 5) {
            //Instantiate rows
            int column = 0;
            while (column < 5) {
                //For each row, instantiate the columns
                gameBoard[row,column] = Instantiate(dungeonTile, new Vector3(5 + (row * 2), 5 + (column * 2), 0), Quaternion.identity);
                column++;
            }
            row++;
        }

        
        
        row = 0;
        column = 0;

        Instantiate(player, gameBoard[row, column].transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        // Move the player
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Went up");
        } 
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Went down");
        } 
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Went left");
        } 
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Went right");
        }
    }
}
