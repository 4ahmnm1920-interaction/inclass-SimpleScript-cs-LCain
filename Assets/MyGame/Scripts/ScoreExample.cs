using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetScore(5, "Joan Bazques");
    }
	
    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void SetScore(int scoreNum, string scoreName)
	{
		int scoreNumValue = scoreNum;
		string scoreNameValue = scoreName;
				
		Debug.Log(scoreNameValue + " has scored " + scoreNumValue + " times!");
	}


}
