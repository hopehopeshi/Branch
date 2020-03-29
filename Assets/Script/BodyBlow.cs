using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyBlow : MonoBehaviour
{
	bool trigger = false;

	float nowTime = 0;

	//TODO Time.deltatimeを使えるように変更すること
	public float setFlame;//動作に何秒かかるか

	public float distance;//進む距離

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
			if (count < setFlame)
			{
				transform.Translate(distance / setFlame, 0, 0);
				count++;
			}
			else
			{
				trigger = false;
				count = 0;
			}


			//if (count < setTime)
			//{
			//	transform.Translate(distance / setTime, 0, 0);
			//}
			//else
			//{
			//	trigger = false;
			//}
			//nowTime += Time.deltaTime;
			//if(nowTime > 1)
			//{
			//	count++;
			//	nowTime = 0;
			//}
		}
	}
	
	public void BodyBlowTrigger()
	{
		trigger = true;
	}
}
