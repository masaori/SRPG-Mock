using UnityEngine;
using System;
using System.Collections;

namespace UnityEngine
{
	public class ExtendedTextField {
		string label;
		float labelWidth;
		float fieldWidth;
		GUILayoutOption[] options;
		
		string inputString = "";
		public string InputString{ get{ return inputString; } }
		
		public ExtendedTextField(string label, float labelWidth, float fieldWidth)
		{
			this.label      = label;
			this.labelWidth = labelWidth;
			this.fieldWidth = fieldWidth;
		}
		
		public void Show()
		{
			GUILayout.BeginHorizontal(GUILayout.Width(labelWidth + fieldWidth));
				GUILayout.Label(label, GUILayout.Width(labelWidth));
				inputString = GUILayout.TextField(inputString, GUILayout.Width(fieldWidth));
			GUILayout.EndHorizontal();
		}
	}
}
