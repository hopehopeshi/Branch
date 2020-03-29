using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMake : MonoBehaviour
{
	public int playerNum;//プレイヤーの数

	GameObject[] player;

	//生成したいモデルのPrehabを入れる
	public GameObject playerOriginal;

	//1体目の生成位置
	public float x;
	public float y;
	public float z;
	
	//複数体生成時の間隔
	public float space;

	// Start is called before the first frame update
    void Start()
    {
		player = new GameObject[playerNum];
		int i = 0;
		while(playerNum> i)
		{
			player[i] = Instantiate(playerOriginal) as GameObject;
			Vector3 pos = player[i].transform.position;
			pos.x = x + i * space;
			pos.y = y;
			pos.z = z;
			player[i].transform.position = pos;

			switch (i % 2)//各プレイヤーのタグ設定　行動決定に使用
			{//ビット演算に変更もあり
				case 0:
				default:
					player[i].tag = "PlayerType1";
					break;
				case 1:
					player[i].tag = "PlayerType2";
					break;
						}						
			i++;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public GameObject[] GetPlayer()
	{
		return player;
	}
	public int GetPlayerNum()
	{
		return playerNum;
	}
}
