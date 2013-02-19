using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine
{
	public class ExtendedScrollView
	{
		public float width;
		Vector2 scrollPos;
		
		
		public void Show(Action innerLayout, params GUILayoutOption[] viewOptions)
		{
			Show(0f, innerLayout, viewOptions);
		}
		
		public void Show(float indent, Action innerLayout, params GUILayoutOption[] viewOptions)
		{
			if (indent > 0)
			{
				ExtendedGUILayout.LayoutHorizontally(() => 
				{
					GUILayout.Label("", GUILayout.Width(indent));
					ShowImpl(indent, innerLayout, viewOptions);
				});
			}
			else
			{
				ShowImpl(indent, innerLayout, viewOptions);	
			}
		}
		
		void ShowImpl(float indent, Action innerLayout, params GUILayoutOption[] viewOptions)
		{
			List<GUILayoutOption> opts = new List<GUILayoutOption>(viewOptions);
			opts.Add(GUILayout.Width(width - indent));
			
			scrollPos = GUILayout.BeginScrollView(scrollPos, opts.ToArray());
			innerLayout();
			GUILayout.EndScrollView();
		}
	}
}
