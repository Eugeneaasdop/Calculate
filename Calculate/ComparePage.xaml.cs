namespace Calculate;

public partial class ComparePage : ContentPage
{
	public ComparePage()
	{
		InitializeComponent();
	}

	private void OnButtonClick(object sender, EventArgs e)
	{
        if (float.TryParse(EntryA.Text, out float a))
        {
            float A = float.Parse(EntryA.Text);
        }
        else
        {
            //MessageBox.Show("Некорректный ввод первого числа!", "Неверный ввод", MessageBoxType.Failed);
            EntryA.Text = "";
        }
        if (float.TryParse(EntryB.Text, out float b))
        {
            float B = float.Parse(EntryB.Text);
        }
        else
        {
            //MessageBox.Show("Некорректный ввод второго числа!", "Неверный ввод", MessageBoxType.Failed);
            EntryB.Text = "";
        }
        string sign = "";
        if (a > b) sign = ">";
        else if (a < b) sign = "<";
        else sign = "=";
        if (EntryA.Text == "" || EntryB.Text == "") LabelResult.Text = "Введите число";
        else LabelResult.Text = $"{a.ToString()} {sign} {b.ToString()}";
    }
}