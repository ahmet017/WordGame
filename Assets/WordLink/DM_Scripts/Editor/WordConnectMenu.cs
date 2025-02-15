﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace WordLink
{
	public class WordConnectMenu : MonoBehaviour
	{
		[MenuItem("Dotmob/Level Editor")]
		public static void OpenLevelBuilderWindow()
		{
			EditorWindow.GetWindow<LevelBuilderWindow>("Level Editor @dotmobstudio");
		}
	}
}
