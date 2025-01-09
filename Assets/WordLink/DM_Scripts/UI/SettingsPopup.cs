using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gley.Localization;
using UnityEngine.UI;
using dotmob;

namespace WordLink
{
	public class SettingsPopup : Popup
	{
		#region Inspector Variables

		[Space]

		[SerializeField] private ToggleSlider	musicToggle = null;
		[SerializeField] private ToggleSlider	soundToggle = null;
		[SerializeField] private string			privacyPolicyUrl;

		//	[SerializeField] private Text HeaderText, MusicText, SoundEffectsText, AllLevelText;

		//[SerializeField] private Dropdown dropdownLang;
		#endregion

		#region Unity Methods

		private void Start()
		{
			//RefreshText();
			musicToggle.SetToggle(SoundManager.Instance.IsMusicOn, false);
			soundToggle.SetToggle(SoundManager.Instance.IsSoundEffectsOn, false);

			musicToggle.OnValueChanged += OnMusicValueChanged;
			soundToggle.OnValueChanged += OnSoundEffectsValueChanged;

		

		}


		private void RefreshText()
        {
			//Debug.Log("......RefreshText ALL TEXT........ ");


			UIController.Instance.UpdateUI();
        }

		
		#endregion

		#region Public Methods

		public void OnPrivacyPolicyClicked()
		{
			Application.OpenURL(privacyPolicyUrl);
		}

		#endregion

		#region Private Methods

		private void OnMusicValueChanged(bool isOn)
		{
			SoundManager.Instance.SetSoundTypeOnOff(SoundManager.SoundType.Music, isOn);
		}

		private void OnSoundEffectsValueChanged(bool isOn)
		{
			SoundManager.Instance.SetSoundTypeOnOff(SoundManager.SoundType.SoundEffect, isOn);
		}

		#endregion
	}
}
