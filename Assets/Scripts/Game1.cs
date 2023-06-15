using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game1 : MonoBehaviour
{
    //Reference from Unity IDE
    public GameObject chesspiece;
    public GameObject painel;
    public GameObject tabuleiro;
    public GameObject vencedor;

    //Matrices needed, positions of each of the GameObjects
    //Also separate arrays for the players in order to easily keep track of them all
    //Keep in mind that the same objects are going to be in "positions" and "playerBlack"/"playerWhite"
    private GameObject[,] positions = new GameObject[8, 8];
    private GameObject[] playerBlack = new GameObject[8];
    private GameObject[] playerWhite = new GameObject[8];

    //current turn
    private string currentPlayer = "white";

    //Game Ending
    private bool gameOver = false;

    //Unity calls this right when the game starts, there are a few built in functions
    //that Unity can call for you
    public void Start()
    {
        
    }

    public void iniciGame()
    {
        painel.SetActive(false);
        tabuleiro.SetActive(true);
        playerWhite = new GameObject[] { Create("white_pawn", 3, 0) };
        playerBlack = new GameObject[] { Create("black_king",4,7), //Create("black_rook", 2, 2), Create("black_knight",4,2),
            // Create("black_bishop",1,4), Create("black_queen",3,5), 
            // Create("black_bishop",3,6), Create("black_knight",5,5) Create("black_rook",7,7),
            Create("black_pawn", 2, 2), Create("black_pawn", 4,2), Create("black_pawn",1,4),
            Create("black_pawn", 3,5), Create("black_pawn", 3,6), Create("black_pawn", 5,5),
            // Create("black_pawn", 6, 6), Create("black_pawn", 7, 6)
             };
            SetPosition(playerWhite[0]);
        //Set all piece positions on the positions board
        for (int i = 0; i < playerBlack.Length; i++)
        {
            SetPosition(playerBlack[i]);
        }
    }

    public GameObject Create(string name, int x, int y)
    {
        GameObject obj = Instantiate(chesspiece, new Vector3(0, 0, -1), Quaternion.identity);
        Chessman1 cm = obj.GetComponent<Chessman1>(); //We have access to the GameObject, we need the script
        cm.name = name; //This is a built in variable that Unity has, so we did not have to declare it before
        cm.SetXBoard(x);
        cm.SetYBoard(y);
        cm.Activate(); //It has everything set up so it can now Activate()
        return obj;
    }

    public void SetPosition(GameObject obj)
    {
        Chessman1 cm = obj.GetComponent<Chessman1>();

        //Overwrites either empty space or whatever was there
        positions[cm.GetXBoard(), cm.GetYBoard()] = obj;
    }

    public void SetPositionEmpty(int x, int y)
    {
        positions[x, y] = null;
    }

    public GameObject GetPosition(int x, int y)
    {
        return positions[x, y];
    }

    public bool PositionOnBoard(int x, int y)
    {
        if (x < 0 || y < 0 || x >= positions.GetLength(0) || y >= positions.GetLength(1)) return false;
        return true;
    }

    public string GetCurrentPlayer()
    {
        return currentPlayer;
    }

    public bool IsGameOver()
    {
        return gameOver;
    }

    public void NextTurn()
    {
        if (currentPlayer == "white")
        {
            currentPlayer = "white";
        }
        else
        {
            currentPlayer = "white";
        }
    }

    public void recomecar()
    {
        SceneManager.LoadScene("TesteMovimentos"); 
    }

    public void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            gameOver = false;

            //Using UnityEngine.SceneManagement is needed here
            SceneManager.LoadScene("Game1"); //Restarts the game by loading the scene over again
        }
    }
    
    public void Winner(string playerWinner)
    {
        tabuleiro.SetActive(false);
        vencedor.SetActive(true);
        GameObject peaoB = GameObject.Find("white_pawn");
        peaoB.SetActive(false);
        for (int i = 0; i < 4; i++)
        {
            GameObject peao = GameObject.Find("black_pawn");
            peao.SetActive(false);
        }
        // gameOver = true;

        // //Using UnityEngine.UI is needed here
        // GameObject.FindGameObjectWithTag("WinnerText").GetComponent<Text>().enabled = true;
        // GameObject.FindGameObjectWithTag("WinnerText").GetComponent<Text>().text = " O jogador " + playerWinner + " é o vencedor.";

        // GameObject.FindGameObjectWithTag("RestartText").GetComponent<Text>().enabled = true;
    }
}