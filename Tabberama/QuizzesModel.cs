using System.Collections.ObjectModel;
using System.IO.Compression;

namespace Tabberama;

public class QuizzesModel
{

    ObservableCollection<Question> Questions { get; set; }
    public Question CurrentQuestion { get; set; }
    public QuizzesModel()
    {
        Questions = new ObservableCollection<Question>();
        Questions.Add(new Question("What is the population of the UK?", new String[] { "60 million", "65 million", "70 million", "75 million" }, "Statistics: 5 attempts, 3 correct, 15 seconds remaining"));
        Questions.Add(new Question("Where is the UK?", new String[] { "Europe", "Asia", "Africa", "North America" }, "Statistics: 5 attempts, 3 correct, 35 seconds remaining"));
        Questions.Add(new Question("Who is the Prime Minister of the UK?", new String[] { "Boris Johnson", "Tony Blair", "David Cameron", "Theresa May" }, "Statistics: 5 attempts, 3 correct, 30 seconds remaining"));
        Questions.Add(new Question("What is the capital of the UK?", new String[] { "London", "Manchester", "Birmingham", "Liverpool" }, "Statistics: 5 attempts, 3 correct, 60 seconds remaining"));
        CurrentQuestion = Questions[0];
    }
}

public class Question
{
    public String CurrentQuestion { get; set; }
    public String[] Answers { get; set; }
    public String Statistics { get; set; }

    public Question(String question, String[] answers, String statistics)
    {
        CurrentQuestion = question;
        Answers = answers;
        Statistics = statistics;
    }
}