namespace Calculator;

public partial class ComparePage : ContentPage
{
	public ComparePage()
	{
		InitializeComponent();
	}

    private void ButtonCompare_Clicked(object sender, EventArgs e)
    {
		float a = float.Parse(EntryA.Text);
        float b = float.Parse(EntryB.Text);
		string sign = "";
		if (a > b)
			sign = ">";
		else if (a < b)
			sign = "<";
		else
			sign = "=";
		LabelResult.Text = $"{a.ToString()} {sign} {b.ToString()}";
	}
}