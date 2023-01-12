public class Memory
{
    public List<string>sentences = new List<string>();
    public List<string>questions = new List<string>();
    public List<string> loadings = new List<string>();

    public void AddToSentences (string idea)
    {
        sentences.Add(idea);
    }
    public void AddToQuestions (string idea)
    {
        questions.Add(idea);
    }

    public void PrintAddQuestionIdea()
    {
        Terminal myTerminal = new Terminal();
        
        
        for (int i = 0; i <= sentences.Count() -1; i++)
        {
            string question = questions[i];
            string sentence = sentences[i];
            myTerminal.DisplayJourney(sentence,question);

        }
    }
    public void PrintLoading()
    {
        for (int i = 0; i <= loadings.Count() -1; i++)
        {
            string loading = loadings[i];
            Console.WriteLine(loading);
            
            

        }

    }
}
