﻿/*
 * Created on 2024
 *
 * Copyright (c) 2024 dotmobstudio
 * Support : dotmobstudio@gmail.com
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace dotmob
{
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(CanvasGroup))]
	public class ScreenBackButton : MonoBehaviour
	{
		#region Inspector Variables

		[SerializeField] private float fadeDuration = 0.5f;

		#endregion

		#region Properties

		private Button		Button		{ get { return gameObject.GetComponent<Button>(); } }
		private CanvasGroup	CanvasGroup	{ get { return gameObject.GetComponent<CanvasGroup>(); } }

		#endregion

		#region Unity Methods

		private void Start()
		{
			Button.onClick.AddListener(OnButtonClicked);

			CanvasGroup.alpha = 0f;

			ScreenManager.Instance.OnSwitchingScreens += OnSwitchingScreens;
		}

		#endregion

		#region Private Methods

		private void OnButtonClicked()
		{
			ScreenManager.Instance.Back();
		}

		private void OnSwitchingScreens(string fromScreenId, string toScreenId)
		{
			if (toScreenId == ScreenManager.Instance.HomeScreenId)
			{
				// Fade out the back button
				PlayAnimation(UIAnimation.Alpha(gameObject, 1f, 0f, fadeDuration));
			}
			else if (fromScreenId == ScreenManager.Instance.HomeScreenId)
			{
				// Fade in the back button
				PlayAnimation(UIAnimation.Alpha(gameObject, 0f, 1f, fadeDuration));
			}
		}

		private void PlayAnimation(UIAnimation anim)
		{
			anim.style				= UIAnimation.Style.EaseOut;
			anim.startOnFirstFrame	= true;
			anim.Play();
		}

		#endregion
	}
}
