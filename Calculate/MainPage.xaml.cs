namespace Calculate;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private void OnButtonClick(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
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
        float c = 0;
        string result = "";

        switch (btn.Text)
        {
            case "+":
                c = a + b;
                break;
            case "-":
                c = a - b;
                break;
            case "*":
                c = a * b;
                break;
            case "/":
                if (b != 0)
                    c = a / b;
                else
                    result = "Деление на 0";
                break;
        }
        if (string.IsNullOrEmpty(result))
        {
            result = c.ToString();
        }
        if (EntryA.Text == "" || EntryB.Text == "") result = "Введите число";
        LabelResult.Text = result;
    }
}

