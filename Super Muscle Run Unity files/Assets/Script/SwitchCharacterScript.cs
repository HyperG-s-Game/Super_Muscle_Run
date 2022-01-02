using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacterScript : MonoBehaviour {

	// referenses to controlled game objects
	public GameObject avatar1, avatar2, avatar3, avatar4, avatar5, 
					  avatar6, avatar7, avatar8, avatar9, avatar10, 
					  avatar11, avatar12, avatar13, avatar14, avatar15, avatar16;

	// variable contains which avatar is on and active
	int whichAvatarIsOn = 1;

	// Use this for initialization
	void Start () {

		avatar1.gameObject.SetActive(true);
		avatar2.gameObject.SetActive(false);
		avatar3.gameObject.SetActive(false);
		avatar4.gameObject.SetActive(false);
		avatar5.gameObject.SetActive(false);
		avatar6.gameObject.SetActive(false);
		avatar7.gameObject.SetActive(false);
		avatar8.gameObject.SetActive(false);
		avatar9.gameObject.SetActive(false);
		avatar10.gameObject.SetActive(false);
		avatar11.gameObject.SetActive(false);
		avatar12.gameObject.SetActive(false);
		avatar13.gameObject.SetActive(false);
		avatar14.gameObject.SetActive(false);
		avatar15.gameObject.SetActive(false);
		avatar16.gameObject.SetActive(false);
	}

	//If player consume fat
	public void Fat()
    {
		if (whichAvatarIsOn == 1)
		{
			whichAvatarIsOn = 2;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(true);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 2)
        {
			whichAvatarIsOn = 3;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(true);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 4)
		{
			whichAvatarIsOn = 5;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(true);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 5)
		{
			whichAvatarIsOn = 6;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(true);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 7)
		{
			whichAvatarIsOn = 8;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(true);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 8)
		{
			whichAvatarIsOn = 9;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(true);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 10)
		{
			whichAvatarIsOn = 11;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(true);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 11)
		{
			whichAvatarIsOn = 12;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(true);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 13)
		{
			whichAvatarIsOn = 14;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(true);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 14)
		{
			whichAvatarIsOn = 15;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(true);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 15)
		{
			whichAvatarIsOn = 16;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(true);
		}


	}


	//If Player consume Muscle
	public void Muscle()
	{
		if (whichAvatarIsOn == 1)
		{
			whichAvatarIsOn = 4;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(true);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 2)
		{
			whichAvatarIsOn = 1;
			avatar1.gameObject.SetActive(true);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 3)
		{
			whichAvatarIsOn = 2;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(true);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 4)
		{
			whichAvatarIsOn = 7;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(true);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 5)
		{
			whichAvatarIsOn = 4;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(true);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 6)
		{
			whichAvatarIsOn = 5;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(true);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 7)
		{
			whichAvatarIsOn = 10;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(true);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 8)
		{
			whichAvatarIsOn = 7;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(true);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 9)
		{
			whichAvatarIsOn = 8;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(true);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 10)
		{
			whichAvatarIsOn = 13;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(true);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 11)
		{
			whichAvatarIsOn = 10;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(true);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 12)
		{
			whichAvatarIsOn = 11;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(true);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 14)
		{
			whichAvatarIsOn = 13;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(true);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 15)
		{
			whichAvatarIsOn = 14;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(true);
			avatar15.gameObject.SetActive(false);
			avatar16.gameObject.SetActive(false);
		}
		else if (whichAvatarIsOn == 16)
		{
			whichAvatarIsOn = 15;
			avatar1.gameObject.SetActive(false);
			avatar2.gameObject.SetActive(false);
			avatar3.gameObject.SetActive(false);
			avatar4.gameObject.SetActive(false);
			avatar5.gameObject.SetActive(false);
			avatar6.gameObject.SetActive(false);
			avatar7.gameObject.SetActive(false);
			avatar8.gameObject.SetActive(false);
			avatar9.gameObject.SetActive(false);
			avatar10.gameObject.SetActive(false);
			avatar11.gameObject.SetActive(false);
			avatar12.gameObject.SetActive(false);
			avatar13.gameObject.SetActive(false);
			avatar14.gameObject.SetActive(false);
			avatar15.gameObject.SetActive(true);
			avatar16.gameObject.SetActive(false);
		}

	}
}
