using System.Net.Http.Json;

namespace WhoWantToBeMillionaire
{

    internal class Program
    {

        static int questionNo = 1;
        static int[] awardList = { 500, 1000, 2000, 5000, 10000, 20000, 50000, 75000, 150000, 250000, 500000, 1000000 };
        static int currentAnswerNo;
        static int correctAnswerNo;

        static string[] GetQuestion(int questionNumber){
            string[] q1 = { "What is the largest ocean in the world?", "Indian Ocean", "Atlantic Ocean", "Pacific Ocean", "Pacific Ocean" };
            string[] q2 = { "Which planet is the 4th in the Solar System?", "Venus", "Mars", "Jupiter", "Mars" };
            string[] q3 = { "Which planet is also known as the \"Red Planet\"?", "Mars", "Venus", "Neptune", "Mars" };
            string[] q4 = { "Which planet has the largest diameter in the Solar System?", "Venus", "Jupiter", "Uranus", "Jupiter" };
            string[] q5 = { "Which planet is the closest to the Sun?", "Mercury", "Venus", "Mars", "Mercury" };
            string[] q6 = { "Which element is represented by the symbol \"Fe\" in the periodic table?", "Phosphorus", "Iron", "Fluorine", "Iron" };
            string[] q7 = { "Which planet is also called the \"Morning Star\" or the \"Evening Star\"?", "Mars", "Venus", "Neptune", "Venus" };
            string[] q8 = { "What is the largest organ in the human body?", "Lung", "Brain", "Skin", "Skin" };
            string[] q9 = { "Which planet is the fastest spinning in the Solar System?", "Mars", "Jupiter", "Venus", "Venus" };
            string[] q10 = { "Which famous artist painted the artwork \"Mona Lisa\"?", "Leonardo da Vinci", "Pablo Picasso", "Vincent van Gogh", "Leonardo da Vinci" };

            string[][] questions = { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10 };

            return questions[questionNumber - 1];
        }

        static void ShowCurrentStatus(){
            Console.WriteLine("==========CURRENT STATUS==========");
            Console.WriteLine($"Question NO - {questionNo}".PadLeft(34));
            if (questionNo > 1) Console.WriteLine($"You won - {awardList[questionNo - 1]}");

            Console.WriteLine("==================================");
        }


        static void ShowQuestion(string[] question){
            Console.WriteLine($"Question : {question[0]}");
            Console.WriteLine($"1. {question[1]}");
            Console.WriteLine($"2. {question[2]}" );
            Console.WriteLine($"3. {question[3]}" );
            Console.WriteLine($"Correct answer: {question[4]}");
            int optionIndex;

            do {
                Console.Write("Your answer : ");
                optionIndex = Convert.ToInt32(Console.ReadLine());
            } while (optionIndex < 1 || optionIndex > 3);

            currentAnswerNo = optionIndex;
        }

        static bool CheckAnswer(){
            if (currentAnswerNo != correctAnswerNo) return false;
            
            return true;
        }

        static void GetAndShowQuestion(){
            string[] currentQuestion = GetQuestion(questionNo);

            for (int i = 0; i < currentQuestion.Length; i++){
                if (currentQuestion[i] == currentQuestion[4]){
                    correctAnswerNo = i;
                    break;
                }
            }


            ShowQuestion(currentQuestion);

            questionNo += 1;
        }

        static void Start(){

            do{
                ShowCurrentStatus();
                GetAndShowQuestion();
                Console.Clear();
            } while (CheckAnswer() && questionNo <= 10);

            if(questionNo >= 10){
                Console.WriteLine("Won");
            }
            else
            {
                Console.WriteLine("Wrong answer you loooooooooser");
            }

        }



        static void  Main(string[] args){
            Start();
        }
    }
}