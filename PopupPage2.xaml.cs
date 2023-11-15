using CommunityToolkit.Maui.Views;
namespace MauiComm_VerifyPopupAndroid;

public partial class PopupPage2 : Popup
{
	public PopupPage2()
	{
		InitializeComponent();
	}

	void gd_Tapped(object sender, EventArgs e)
	{
		this.Close();
	}
}