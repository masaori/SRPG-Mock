using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CamSelector : MonoBehaviour
{
	[SerializeField] GameObject[] cameras;
	[SerializeField] GameObject[] objects;
	
	List<GameObject> cameraList;
	List<GameObject> objectList;
	List<ExtendedButton> cameraButtons = new List<ExtendedButton>();
	List<ExtendedButton> objectButtons = new List<ExtendedButton>();
	
	const float buttonWidth  = 200f;
	const float buttonHeight = 40f;
	
	void Start()
	{
		cameraList = new List<GameObject>(cameras);
		objectList = new List<GameObject>(objects);

		CreateButtons(cameraList, cameraButtons);
		CreateButtons(objectList, objectButtons);
	}
	
	void CreateButtons(List<GameObject> list, List<ExtendedButton> buttonList)
	{
		list.ForEach((c) =>
		{
			ExtendedButton temp = new ExtendedButton(c.name, GUILayout.Width(buttonWidth), GUILayout.Height(buttonHeight));
			temp.AddDelegate((button) =>
			{
				list.ForEach((obj) =>
				{
					if (obj == c)
						obj.active = true;
					else
						obj.active = false;
				});
			});
			buttonList.Add(temp);
		});			
	}
	
	void OnGUI()
	{
		GUILayout.Label("Select Camera");
		cameraButtons.ForEach((button) =>
		{
			button.Show();
		});
		
		GUILayout.Label("Select Object");
		objectButtons.ForEach((button) =>
		{
			button.Show();
		});

	}
}
