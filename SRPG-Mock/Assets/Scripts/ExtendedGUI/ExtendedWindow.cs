using UnityEngine;
using System;
using System.Collections;

public class ExtendedWindow
{
	protected bool visible = false;
	protected string title;
	protected Rect rect;
	protected Rect innerRect;
	
	public ExtendedWindow(string title, Rect rect, float padding=0f)
	{
		this.title     = title;
		this.rect      = rect;
		this.innerRect = new Rect(rect.xMin + padding, rect.yMin + padding, rect.width - padding*2f, rect.height  - padding*2f);
	}
	
	public void Show(Action innerLayout)
	{
		if (visible)
		{
			GUI.Box(rect, title);
			
			GUILayout.BeginArea(innerRect);
			if (innerLayout != null) innerLayout();
			GUILayout.EndArea();
		}			
	}
	
	public void SetVisible(bool visible)
	{
		this.visible = visible;	
	}
}
