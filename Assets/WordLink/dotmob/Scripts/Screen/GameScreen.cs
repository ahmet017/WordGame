/*
 * Created on 2024
 *
 * Copyright (c) 2024 dotmobstudio
 * Support : dotmobstudio@gmail.com
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordLink;
using Gley.Localization;
using UnityEngine.UI;
namespace dotmob
{


    public class GameScreen : Screen
    {

        public Text CoinAmountText;

        // Start is called before the first frame update
        void Start()
        {
           // UIController.Instance.RefeshtopBarLevelText();
        }

        private void Update()
        {
            RefreshText();
            
        }

        private void RefreshText()
        {
            CoinAmountText.text = API.GetText(WordIDs.VideoRewardText_MainMenu);
        }


    }
}