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

    public class ProductPurchasedPopup : Popup
    {

        [SerializeField] private Text Header, MessageText;

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
            if(Header != null && MessageText != null)
            {
                Header.text = API.GetText(WordIDs.ProductPurchasedPopup_Header);
                MessageText.text = API.GetText(WordIDs.ProductPurchasedPopup_MessageText);

            }
        }
    }
}