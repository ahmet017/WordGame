/*
 * Created on 2024
 *
 * Copyright (c) 2024 dotmobstudio
 * Support : dotmobstudio@gmail.com
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gley.Localization;
using UnityEngine.UI;
using dotmob;

namespace WordLink
{

	public class LangController : SingletonComponent<LangController>
	{
		[SerializeField] private Dropdown dropdownLang;


		private void Start()
		{

			dropdownLang.onValueChanged.AddListener(delegate
			{
				DropdownValueChanged(dropdownLang);
			});

			// Load saved value
			int savedValue = PlayerPrefs.GetInt("SelectedDropdownValue", 0); // default value is 0
			dropdownLang.value = savedValue;

		}


		private void RefreshText()
		{
			//Debug.Log("......RefreshText ALL TEXT........ ");


			UIController.Instance.UpdateUI();
			//UIController.Instance.OnNewLevelStarted();
			//RewardAdGrantedPopup.In
		}

		void DropdownValueChanged(Dropdown change)
		{
			// Save selected value
			PlayerPrefs.SetInt("SelectedDropdownValue", change.value);
			PlayerPrefs.Save();

			// You can perform other actions based on the selected value if needed
			Debug.Log("Selected Dropdown Value: " + change.value);
		}

		public void GetDropDowValue()
		{
			//int indexDropDow = dropdownLang.value;

			Debug.Log("DROPDOW LANG :" + dropdownLang.value);

			switch (dropdownLang.value)
			{
				case 0:
					Gley.Localization.API.SetCurrentLanguage(SupportedLanguages.English);
					RefreshText();
					break;
				case 1:
					Gley.Localization.API.SetCurrentLanguage(SupportedLanguages.French);
					RefreshText();
					break;

				case 2:
					Gley.Localization.API.SetCurrentLanguage(SupportedLanguages.Spanish);
					RefreshText();
					break;
				case 3:
					Gley.Localization.API.SetCurrentLanguage(SupportedLanguages.Turkish);
					RefreshText();
					break;
				case 4:
					Gley.Localization.API.SetCurrentLanguage(SupportedLanguages.Korean);
					RefreshText();
					break;
			}
		}
	}
}