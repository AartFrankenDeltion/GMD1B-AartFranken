using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	public static int score = 0;
	public TextMesh display;
	
	void Update()
	{
		if(display)
		{
			display.text = score.ToString("D8");
		}
	}
}
