using CommunityToolkit.Maui.Views;
namespace MauiComm_VerifyPopupAndroid;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void btnTest1_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		var popup = new PopupPage1();
		popup.Size = new Size(popupWidth, popupHeight);
		popup.VerticalOptions = verticalOptions;
		popup.HorizontalOptions = horizontalOptions;
		if (popup.Content is not null)
		{
			popup.Content.WidthRequest = contentWidth;
			popup.Content.HeightRequest = contentHeight;
		}
		this.ShowPopup(popup);
	}

	void btnTest2_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		var popup = new PopupPage2();
		popup.Size = new Size(popupWidth, popupHeight);
		popup.VerticalOptions = verticalOptions;
		popup.HorizontalOptions = horizontalOptions;
		if (popup.Content is not null)
		{
			popup.Content.WidthRequest = contentWidth;
			popup.Content.HeightRequest = contentHeight;
		}
		this.ShowPopup(popup);
	}

	void btnTest3_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		var popup = new PopupPage3();
		popup.Size = new Size(popupWidth, popupHeight);
		popup.VerticalOptions = verticalOptions;
		popup.HorizontalOptions = horizontalOptions;
		if (popup.Content is not null)
		{
			popup.Content.WidthRequest = contentWidth;
			popup.Content.HeightRequest = contentHeight;
		}
		this.ShowPopup(popup);
	}

	void btnTest4_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		var popup = new PopupPage4();
		popup.Size = new Size(popupWidth, popupHeight);
		popup.VerticalOptions = verticalOptions;
		popup.HorizontalOptions = horizontalOptions;
		if (popup.Content is not null)
		{
			popup.Content.WidthRequest = contentWidth;
			popup.Content.HeightRequest = contentHeight;
		}
		this.ShowPopup(popup);
	}

	void btnTest5_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		var popup = new PopupPage5();
		popup.Size = new Size(popupWidth, popupHeight);
		popup.VerticalOptions = verticalOptions;
		popup.HorizontalOptions = horizontalOptions;
		if (popup.Content is not null)
		{
			popup.Content.WidthRequest = contentWidth;
			popup.Content.HeightRequest = contentHeight;
		}
		this.ShowPopup(popup);
	}

	void btnTest6_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		var popup = new PopupPage6();
		popup.Size = new Size(popupWidth, popupHeight);
		popup.VerticalOptions = verticalOptions;
		popup.HorizontalOptions = horizontalOptions;
		if (popup.Content is not null)
		{
			popup.Content.WidthRequest = contentWidth;
			popup.Content.HeightRequest = contentHeight;
		}
		this.ShowPopup(popup);
	}

	void btnTest7_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		var popup = new PopupPage7();
		popup.Size = new Size(popupWidth, popupHeight);
		popup.VerticalOptions = verticalOptions;
		popup.HorizontalOptions = horizontalOptions;
		if (popup.Content is not null)
		{
			popup.Content.WidthRequest = contentWidth;
			popup.Content.HeightRequest = contentHeight;
		}
		this.ShowPopup(popup);
	}

	async void btnTest8_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		await Task.Delay(3000);

		MainThread.BeginInvokeOnMainThread(async () =>
		{
			var popup = new PopupPage8();
			popup.Size = new Size(popupWidth, popupHeight);
			popup.VerticalOptions = verticalOptions;
			popup.HorizontalOptions = horizontalOptions;
			if (popup.Content is not null)
			{
				popup.Content.WidthRequest = contentWidth;
				popup.Content.HeightRequest = contentHeight;
			}
			await this.ShowPopupAsync(popup);
		});
	}

	async void btnTest9_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		await Task.Delay(3000);

		MainThread.BeginInvokeOnMainThread(async () =>
		{
			var popup = new PopupPage9();
			popup.Size = new Size(popupWidth, popupHeight);
			popup.VerticalOptions = verticalOptions;
			popup.HorizontalOptions = horizontalOptions;
			if (popup.Content is not null)
			{
				popup.Content.WidthRequest = contentWidth;
				popup.Content.HeightRequest = contentHeight;
			}
			await this.ShowPopupAsync(popup);
		});
	}

	async void btnTest10_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		await Task.Delay(3000);

		MainThread.BeginInvokeOnMainThread(async () =>
		{
			var popup = new PopupPage10();
			popup.Size = new Size(popupWidth, popupHeight);
			popup.VerticalOptions = verticalOptions;
			popup.HorizontalOptions = horizontalOptions;
			if (popup.Content is not null)
			{
				popup.Content.WidthRequest = contentWidth;
				popup.Content.HeightRequest = contentHeight;
			}
			await this.ShowPopupAsync(popup);
		});
	}

	async void btnTest11_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		await Task.Delay(3000);

		MainThread.BeginInvokeOnMainThread(async () =>
		{
			var popup = new PopupPage11();
			popup.Size = new Size(popupWidth, popupHeight);
			popup.VerticalOptions = verticalOptions;
			popup.HorizontalOptions = horizontalOptions;
			if (popup.Content is not null)
			{
				popup.Content.WidthRequest = contentWidth;
				popup.Content.HeightRequest = contentHeight;
			}
			await this.ShowPopupAsync(popup);
		});
	}

	void btnTest12_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		double popupWidth = string.IsNullOrEmpty(txtPopupWidth.Text) ? 0 : double.Parse(txtPopupWidth.Text);
		double popupHeight = string.IsNullOrEmpty(txtPopupHeight.Text) ? 0 : double.Parse(txtPopupHeight.Text);

		double contentWidth = string.IsNullOrEmpty(txtContentWidth.Text) ? double.NaN : double.Parse(txtContentWidth.Text);
		double contentHeight = string.IsNullOrEmpty(txtContentHeight.Text) ? double.NaN : double.Parse(txtContentHeight.Text);

		var popup = new PopupPage12();
		popup.Size = new Size(popupWidth, popupHeight);
		popup.VerticalOptions = verticalOptions;
		popup.HorizontalOptions = horizontalOptions;
		if (popup.Content is not null)
		{
			popup.Content.WidthRequest = contentWidth;
			popup.Content.HeightRequest = contentHeight;
		}
		this.ShowPopup(popup);
	}
}

