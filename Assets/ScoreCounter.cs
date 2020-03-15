using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

    private int score = 0;

    private GameObject scoreText;

    // Use this for initialization
    void Start () {

        this.scoreText = GameObject.Find("ScoreText");
    }
	
	// Update is called once per frame
	void Update () {

    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }
        else if(other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
        {
            score += 30;
        }

        this.scoreText.GetComponent<Text>().text = score.ToString();

    }
}
