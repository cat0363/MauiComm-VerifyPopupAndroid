using Microsoft.Maui.Controls.Internals;

namespace MauiComm_VerifyPopupAndroid;

public partial class PopupPage4
{
    public PopupPage4(bool immediately = false)
    {
        InitializeComponent();

        if (immediately)
        {
            testlabel4.Text = testlabel2.Text = "This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines.";
            testlabel1.Text = testlabel3.Text = "Test123";
        }
        else
        {
            Dispatcher.DispatchDelayed(TimeSpan.FromSeconds(0.5), () =>
            {
                testlabel4.Text = testlabel2.Text = "This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines. This should split into multiple lines.";
                testlabel1.Text = testlabel3.Text = "Test123";
            });
        }
    }
}