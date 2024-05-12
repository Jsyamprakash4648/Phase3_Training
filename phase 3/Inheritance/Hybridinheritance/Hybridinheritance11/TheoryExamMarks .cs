using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybridinheritance11
{
    public class TheoryExamMarks:PersonalInfo
    {
        //Properties: Sem1[], Sem2[], Sem3[], Sem4[] Marks – 6 marks in each sem.

        public int[] Sem1 { get; set; }=new int[6];
        public int[] Sem2 { get; set; }=new int[6];
        public int[] Sem3 { get; set; }=new int[6];
        public int[] Sem4 { get; set; }=new int[6];


        






    }
}