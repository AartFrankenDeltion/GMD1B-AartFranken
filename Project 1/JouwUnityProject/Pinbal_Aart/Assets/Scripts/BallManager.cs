using UnityEngine;
using System.Collections;

public class BallManager : MonoBehaviour
{
	public GameObject ball;
	public Transform spawnPosition;
	public TextMesh display;
	public int lives = 3;
	public bool gameOver = false;
	
	void Update()
	{
		//Check for gameover
		if(lives < 0)
		{
			if(display)
			{
				display.text = "GAME OVER";
				gameOver = true;
			}
		}
		
		//Ball has drained and game is not over
		if(!GameObject.FindGameObjectWithTag("Ball") && !gameOver)
		{
			lives--;
			Instantiate(ball,spawnPosition.position,ball.transform.rotation);
			//Update balls remaining
			if(display)
			{
				display.text = lives.ToString();
			}
		}
		
		//Reset game with return key if game is over
		if(gameOver)
		{
			if(Input.GetKeyDown(KeyCode.Return))
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}
