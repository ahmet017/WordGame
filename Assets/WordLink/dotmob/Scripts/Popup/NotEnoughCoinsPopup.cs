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
using dotmob;
using UnityEngine.UI;

namespace WordLink
{
    public class NotEnoughCoinsPopup : Popup
    {

        [SerializeField] private Text Header, OpenStoreText, NoThanksText;
        // Start is called before the first frame update
        void Start()
        {
            RefreshText();
        }

         public override void OnShowing(object[] inData)
        {
            base.OnShowing(inData);

            RefreshText();
        }

        void RefreshText()
        {
            if (Header != null && OpenStoreText != null && NoThanksText != null)
            {
                Header.text = API.GetText(WordIDs.NotEnoughCoinsPopup_Header);
                OpenStoreText.text = API.GetText(WordIDs.NotEnoughCoinsPopup_OpenStore);
                NoThanksText.text = API.GetText(WordIDs.NotEnoughCoinsPopup_No);

            }
        }

    }
}
