namespace Tabberama;

public partial class QuizPage : ContentPage
{
	public QuizPage()
	{
		BindingContext = MauiProgram.QuizzesModel.CurrentQuestion; // We need this to bind the properties to the UI
		InitializeComponent();
	}
}
