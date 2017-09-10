using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SgLib;
using System.Collections.Generic;

public enum GameState
{
    Prepare,
    Playing,
    Paused,
    PreGameOver,
    GameOver
}

public class GameManager : MonoBehaviour
{

    public static int GameCount
    { 
        get { return _gameCount; } 
        private set { _gameCount = value; } 
    }

    private static int _gameCount = 0;

    public static event System.Action<GameState, GameState> GameStateChanged = delegate {};

    public GameState GameState
    {
        get
        {
            return _gameState;
        }
        private set
        {
            if (value != _gameState)
            {
                GameState oldState = _gameState;
                _gameState = value;

                GameStateChanged(_gameState, oldState);
            }
        }
    }

    private GameState _gameState = GameState.Prepare;

    [Header("Check to enable premium features (require EasyMobile plugin)")]
    public bool enablePremiumFeatures = true;

    [Header("Gameplay References")]
    public UIManager uIManager;
   
    [HideInInspector]
    public GameObject currentTargetPoint;
    [HideInInspector]
    public GameObject currentTarget;
    public ParticleSystem die;
    public ParticleSystem hitGold;
    [HideInInspector]
    public bool gameOver;

    

    
    
   
    // Use this for initialization
    void Start()
    {
        GameState = GameState.Prepare;
	    ScoreManager.Instance.Reset();
    
        if (!UIManager.firstLoad)
        {
            StartGame();
           
        }
    }
	
    // Update is called once per frame
    void Update()
    {
       
    }

    /// <summary>
    /// Fire game event, create gold
    /// </summary>
    public void StartGame()
    {
        GameState = GameState.Playing;
	
    }

    void GameOver()
    {
        GameState = GameState.GameOver;
    }

    

 
    
    /// <summary>
    /// Check game over
    /// </summary>
    /// <param name="the ball"></param>
    public void CheckGameOver(GameObject ball)
    {
        
			Debug.Log ("Open Game Over popup");
		    GameOver();           
        
    }

}
