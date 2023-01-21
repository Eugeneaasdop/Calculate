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
            //MessageBox.Show("������������ ���� ������� �����!", "�������� ����", MessageBoxType.Failed);
            EntryA.Text = "";
        }
        if (float.TryParse(EntryB.Text, out float b))
        {
            float B = float.Parse(EntryB.Text);
        }
        else
        {
            //MessageBox.Show("������������ ���� ������� �����!", "�������� ����", MessageBoxType.Failed);
            EntryB.Text = "";
        }
        string sign = "";
        if (a > b) sign = ">";
        else if (a < b) sign = "<";
        else sign = "=";
        if (EntryA.Text == "" || EntryB.Text == "") LabelResult.Text = "������� �����";
        else LabelResult.Text = $"{a.ToString()} {sign} {b.ToString()}";
    }
}