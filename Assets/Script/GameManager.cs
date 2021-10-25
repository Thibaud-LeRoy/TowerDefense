using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance { get; private set; } = null;
 
    public enum GameState
    {
        PREPARATION,
        RUNNING,
        END
    }

    private GameState gameState { get; set; } = GameState.PREPARATION;

    private float gameTimer { get; set; } = 0;

    public float _preparationTime = 10;
    private float preparationTime { get { return _preparationTime; } }




    //-------------------------------------------------------------//  
    //---------------------------   AWAKE   -----------------------//
    //-------------------------------------------------------------//
    private void Awake()
    {
        instance = this;
    }

    //-------------------------------------------------------------//  
    //---------------------------   START   -----------------------//
    //-------------------------------------------------------------//

    private void Start()
    {
        
    }

    //-------------------------------------------------------------//  
    //--------------------------   UPDATE   -----------------------//
    //-------------------------------------------------------------//
    private void Update()
    {
        switch (gameState)
        {
            case GameState.PREPARATION:
                gameTimer += Time.deltaTime;
                if(gameTimer >= _preparationTime)
                {
                    gameTimer = 0;
                    gameState = GameState.RUNNING;
                }
                break;
            case GameState.RUNNING:
                break;
            case GameState.END:
                break;
        }
    }
}