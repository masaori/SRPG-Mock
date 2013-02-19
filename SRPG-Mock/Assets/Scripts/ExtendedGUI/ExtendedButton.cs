using UnityEngine;
using System;
using System.Collections;

namespace UnityEngine
{
	public class ExtendedButton {
		string label;
		GUILayoutOption[] options;
		
		Action<System.Object> onTapped;
		
		public ExtendedButton(string label, params GUILayoutOption[] options)
		{
			this.label    = label;
			this.options  = options;
		}
		
		public void AddDelegate(Action<System.Object> onTapped)
		{
			this.onTapped += onTapped;
		}
		
		public void Show(Action<System.Object> onTappedDelegate=null)
		{
			Show(this, onTappedDelegate);
		}
		
		public void Show(System.Object context, Action<System.Object> onTappedDelegate=null)
		{
			if (GUILayout.Button(label, options))
			{
				if (onTappedDelegate != null)
					onTappedDelegate(context);
				else
					if (onTapped != null)
						onTapped(context);
			}			
		}
	}
}
