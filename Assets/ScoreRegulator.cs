using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRegulator : MonoBehaviour {
	//ゲームオーバを表示するテキスト
	private GameObject scoreText;
	private int addScore = 0;
	private int score = 0;

	// Use this for initialization
	void Start () {
		// タグによって加算される点数を変える
		if (tag == "SmallStarTag") {
			this.addScore = 10;
		} else if (tag == "LargeStarTag") {
			this.addScore = 50;
		} else if(tag == "SmallCloudTag") {
			this.addScore = 20;
		} else if(tag == "LargeCloudTag") {
			this.addScore = 100;
		}
		//シーン中のscoreTextオブジェクトを取得
		this.scoreText = GameObject.Find("ScoreText");
		this.scoreText.GetComponent<Text> ().text = "0";
		//Debug.Log ("初期化終了");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {
		//スコアを加算
		this.score = int.Parse(this.scoreText.GetComponent<Text> ().text);
		this.score += this.addScore;
		string scoreString = this.score.ToString();
		this.scoreText.GetComponent<Text> ().text = scoreString;
	}
}
