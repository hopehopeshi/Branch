using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	PlayerAction p_action;
	// Start is called before the first frame update
	void Start()
	{
		p_action = GameObject.Find("GameDirector").GetComponent<PlayerAction>();
	}
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			p_action.ActionTrigger(Define.Action.MUSIC1);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			p_action.ActionTrigger(Define.Action.MUSIC2);
		}

	}
}
