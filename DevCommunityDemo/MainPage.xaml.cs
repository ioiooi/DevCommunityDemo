using DevCommunityDemo.Models;

namespace DevCommunityDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;


		// Demo https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0007-ide0008
		// not working
		Person person = new Person();
		bool isPerson = person is Person;


		// Demo https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0071
		// not working
		if (count == 1)
			CounterBtn.Text = $"Clicked {count.ToString()} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


