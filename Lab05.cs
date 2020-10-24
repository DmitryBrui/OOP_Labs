using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Испытание, Тест, Экзамен, Выпускной экзамен, Вопрос;

namespace OOP_Lab05
{
    interface IGrading
    {
       int GetMark();
    }
    abstract class Assay : IGrading
    {
        private int _questionAmount;
        private Question[] QuestionArray;

    }

    class Test : Assay
    {

    }

    class Exam : Assay
    {

    }

    class Final_Exam : Exam
    {

    }

    sealed class Question
    {
        private string _question;
        private string _answer;
    }
}
