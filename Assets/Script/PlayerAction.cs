using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Define;

public class PlayerAction : MonoBehaviour
{
	GameObject[] player;

	int action;

	int num;

	// Start is called before the first frame update
    void Start()
    {
		player = GameObject.Find("GameDirector").GetComponent<PlayerMake>().GetPlayer();
		num = GameObject.Find("GameDirector").GetComponent<PlayerMake>().GetPlayerNum();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void ActionTrigger(int i)
	{
		int k = 0;
		while (k < num)
			//TODO 行動中にさらに入力可能になっているので直す
		{
			switch (player[k].tag)
			{
				case Define.playerType.playerType1:
					switch (i)
					{
						case Define.Action.MUSIC1:
							player[k].GetComponent<Jump>().JumpTrigger();
							break;
						case Define.Action.MUSIC2:
							player[k].GetComponent<BodyBlow>().BodyBlowTrigger();
							break;
						default:
							break;
					}
					break;
				case Define.playerType.playerType2:
					switch (i)
					{
						case Define.Action.MUSIC1:
							player[k].GetComponent<BodyBlow>().BodyBlowTrigger();
							break;
						case Define.Action.MUSIC2:
							player[k].GetComponent<Jump>().JumpTrigger();
							break;
						default:
							break;
					}
					break;
				default:
					break;
			}
			k++;
		}
	}
}
