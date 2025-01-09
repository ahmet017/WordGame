using UnityEngine.Events;
using UnityEngine;
using Gley.MobileAds;
//using GoogleMobileAds.Api;
//using GoogleMobileAds.Common;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

namespace dotmob
{
	public class MobileAdsManager : MonoBehaviour
	{



        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        ///// <summary>
        ///// Removes ads for this user
        ///// </summary>
        public void RemoveAds()
        {

            API.RemoveAds(true);



        }

        public bool IsAdRemoved()
        {
            return PlayerPrefs.GetInt("remove_ads") == 1;
        }




      public static MobileAdsManager instance;

        public void Start()
        {
    
            instance = this;

            API.Initialize(OnInitialized);
     
        }

        private void OnInitialized()
        {
            API.ShowBanner(BannerPosition.Bottom, BannerType.Adaptive);

            if (!API.GDPRConsentWasSet())
            {
                API.ShowBuiltInConsentPopup(ClosePop);
            }
        }

        private void ClosePop()
        {
           
        }

        public void ShowInterstitialAd()
        {
           

            if (API.IsInterstitialAvailable())
            {
                API.ShowInterstitial();
            }
          
        }

        public void ShowBanner()
        {

            API.ShowBanner(BannerPosition.Bottom, BannerType.Adaptive);
        }


        public void HideBanner()
        {
            API.HideBanner();
        }




    }
}
