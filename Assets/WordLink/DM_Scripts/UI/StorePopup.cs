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

#if DM_IAP
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
#endif

namespace WordLink
{
	public class StorePopup : Popup
	{
		#region Member Variables

		private bool areAdsRemoved;

		[SerializeField] private Text HeaderText;

		#endregion

		#region Public Methods

		public override void OnShowing(object[] inData)
		{
			RefreshText();
			IAPManager.Instance.OnProductPurchased += OnProductPurchases;
		}

		public override void OnHiding()
		{
			base.OnHiding();

			IAPManager.Instance.OnProductPurchased -= OnProductPurchases;
		}


		void RefreshText()
        {
			if(HeaderText != null)
            {
				HeaderText.text = API.GetText(WordIDs.StorePopup_Header);
            }
        }


		#endregion

		#region Private Methods

		private void OnProductPurchases(string productId)
		{
			Hide(false);

			PopupManager.Instance.Show("product_purchased");
		}

		#endregion
	}
}
