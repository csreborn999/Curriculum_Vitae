using System;
using System.Collections.Generic;
using System.Text;

namespace Curriculum_Vitae_C_Sharp
{
    class transcript
    {
        private string name;//name代表姓名的私有（private）字串資料項目
        private int quiz;//quiz代表小考成績的私有數值資料項目
        private int midterm;//midterm代表期中考成績的私有數值資料項目
        private int var_final;//var_final代表期末考成績的私有數值資料項目
        private string grade;

        public transcript(string name, int quiz, int midterm, int var_final)
        {
            this.name = name;
            this.quiz = quiz;
            this.midterm = midterm;
            this.var_final = var_final;
        }

        public double calScore()//計算學期成績（score）的私有數值資料項目
        {
            return quiz * 0.15 + midterm * 0.35 + var_final * 0.5;
        }

        public string calGrade()//計算成績等第（grade）的私有字元資料項目
        {
            double score = calScore();
            if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "E";
            }
            return (grade);
        }

        public void printReport()//顯示出學生姓名、學期成績與成績等第結果
        {
            Console.WriteLine("name:" + name + "\nquiz    midterm final    score   grade\n" + quiz + "      " + midterm + "      " + var_final + "       " + calScore() + "      " + calGrade());
        }
    }
}
