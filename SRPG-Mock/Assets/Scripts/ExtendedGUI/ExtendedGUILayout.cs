using UnityEngine;
using System;
using System.Collections;

public static class ExtendedGUILayout
{
	public static void LayoutHorizontally(Action layoutBlock)
	{
		if (layoutBlock == null) return;
		
		GUILayout.BeginHorizontal();
		layoutBlock();
		GUILayout.EndHorizontal();
	}
	
	public static void LayoutVertically(Action layoutBlock)
	{
		if (layoutBlock == null) return;
		
		GUILayout.BeginVertical();
		layoutBlock();
		GUILayout.EndVertical();
	}
}
