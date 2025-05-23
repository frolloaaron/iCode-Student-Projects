namespace ArcadeAppZoe;

public partial class Storybook_MainPage : ContentPage
{
    public Storybook_MainPage()
    {
        InitializeComponent();
    }
    private void Page_1_ToggleButton_Clicked(object sender, EventArgs e)
    {
        if (Page_1_TextBox.IsVisible == true)
        {
            Page_1_TextBox.IsVisible = false;
        }
        else
        {
            Page_1_TextBox.IsVisible = true;
        }
    }
    private void Page_2b_ToggleButton_Clicked(object sender, EventArgs e)
    {
        if (Page_2b_TextBox.IsVisible == true)
        {
            Page_2b_TextBox.IsVisible = false;
        }
        else
        {
            Page_2b_TextBox.IsVisible = true;
        }
    }
    private void Page_3b_ToggleButton_Clicked(object sender, EventArgs e)
    {
        if (Page_3b_TextBox.IsVisible == true)
        {
            Page_3b_TextBox.IsVisible = false;
        }
        else
        {
            Page_3b_TextBox.IsVisible = true;
        }
    }


    private async void Ending1_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("storybook_home");
    }
    private async void Ending2_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("storybook_home");
    }
    private async void Ending3_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("storybook_home");
    }
    private async void Ending4_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("storybook_home");
    }

    private async void Page_1_Choice1_Clicked(object sender, EventArgs e)
    {
        Page_1_Choice2.IsEnabled = false;
        Page_2a.Opacity = 0;
        Page_2a.IsVisible = true;

        await Task.Delay(100);
        await scrollview.ScrollToAsync(Page_2a, ScrollToPosition.Start, true);

        await Page_2a.FadeTo(1, 100);
    }
    private async void Page_1_Choice2_Clicked(object sender, EventArgs e)
    {
        Page_1_Choice1.IsEnabled = false;
        Page_2b.Opacity = 0;
        Page_2b.IsVisible = true;

        await Task.Delay(100);
        await scrollview.ScrollToAsync(Page_2b, ScrollToPosition.Start, true);

        await Page_2b.FadeTo(1, 100);
    }
    private async void Page_2b_Choice1_Clicked(object sender, EventArgs e)
    {
        Page_2b_Choice2.IsEnabled = false;
        Page_3a.Opacity = 0;
        Page_3a.IsVisible = true;

        await Task.Delay(100);
        await scrollview.ScrollToAsync(Page_3a, ScrollToPosition.Start, true);

        await Page_3a.FadeTo(1, 100);
    }
    private async void Page_2b_Choice2_Clicked(object sender, EventArgs e)
    {
        Page_2b_Choice1.IsEnabled = false;
        Page_3b.Opacity = 0;
        Page_3b.IsVisible = true;

        await Task.Delay(100);
        await scrollview.ScrollToAsync(Page_3b, ScrollToPosition.Start, true);

        await Page_3b.FadeTo(1, 100);
    }
    private async void Page_3b_Choice2_Clicked(object sender, EventArgs e)
    {
        Page_3b_Choice1.IsEnabled = false;
        Page_4a.Opacity = 0;
        Page_4a.IsVisible = true;

        await Task.Delay(100);
        await scrollview.ScrollToAsync(Page_4a, ScrollToPosition.Start, true);

        await Page_4a.FadeTo(1, 100);
    }
    private async void Page_3b_Choice1_Clicked(object sender, EventArgs e)
    {
        Page_3b_Choice2.IsEnabled = false;
        Page_4b.Opacity = 0;
        Page_4b.IsVisible = true;

        await Task.Delay(100);
        await scrollview.ScrollToAsync(Page_4b, ScrollToPosition.Start, true);

        await Page_4b.FadeTo(1, 100);
    }
}