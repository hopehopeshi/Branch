using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	bool trigger = false;

	float nowTime = 0;

	public float setFlame;//何秒かけて飛ぶか

	public float height;//飛ぶ高さ

	int count = 0;


	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (trigger == true)
		{
			if (count < setFlame / 2)
			{
				transform.Translate(0, (height / setFlame) * 2, 0);
				count++;
			}
			else if (count < setFlame)
			{
				transform.Translate(0,( -height / setFlame) * 2, 0);
				count++;
			}
			else
			{
				trigger = false;
				count = 0;
			}
		}

		//if (trigger == true)
		//{
		//	nowTime += Time.deltaTime;
		//	if (nowTime < setTime/2)
		//	{
		//		transform.Translate(0, height / setTime, 0);
		//	}
		//	else if( nowTime < setTime)
		//	{
		//		transform.Translate(0, -height / setTime, 0);
		//	}
		//	else
		//	{
		//		trigger = false;
		//		nowTime = 0;
		//	}
		//}
	}
	
	public void JumpTrigger()
	{
		trigger = true;
	}
}
