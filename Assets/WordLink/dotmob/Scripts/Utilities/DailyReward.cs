/*
 * Created on 2024
 *
 * Copyright (c) 2024 dotmobstudio
 * Support : dotmobstudio@gmail.com
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using dotmob;
using Gley.DailyRewards;
using Gley.DailyRewards.API;
using dotmob;
using EasyUI.Toast;


namespace WordLink
{


    public class DailyReward : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Calendar.AddClickListener(CalendarButtonClicked);
        }

        private void CalendarButtonClicked(int dayNumber, int rewardValue, Sprite rewardSprite)
        {

            //Calendar.Close();
             
            // Get the current amount of coins
            int animateFromCoins = GameController.Instance.Coins;

            // Give the amount of coins
            GameController.Instance.GiveCoins(rewardValue, false);

            // Get the amount of coins now after giving them
            int animateToCoins = GameController.Instance.Coins;

            Toast.Show("Successful Reward " + rewardValue + " coins!", 3f, ToastColor.Green);

            // Show the popup to the user so they know they got the coins
              PopupManager.Instance.Show("reward_ad_granted", new object[] { rewardValue, animateFromCoins, animateToCoins });

        }

        public void ShowRewardPannel()
        {
          //  Debug.Log("Chay vaof day");
            Calendar.Show();
        }
    }

}