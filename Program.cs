using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int
            //float
            //string
            //bool

            //int[] = new int[크기]
            //시작이 0부터 시작
            //for (초기치; 조건; 증가식)
            //{
            //
            //}
            //if



            //절차지향 프로그래밍 - 협업이 어려움
            //객체지향 프로그래밍 - 

            //점수를 입력 받았어요.
            //A : 90 ~ 100
            //B : 80 ~ 90
            //C : 70 ~ 80
            //D : 60 ~ 70
            //F : 0 ~ 60

            //클론에서 작업 추가
            //싱크 (풀로 받음)

            int score = 99;
            int scoreDivide = score / 10;
            string grade = "F";
            float average = 0.3546f;

            int sum = score + (int)average;
            float fsum = (float)score + average;
            Console.WriteLine(sum);
            Console.WriteLine(fsum);

            switch (scoreDivide)
            {
                case 10:
                    grade = "A";
                    break;
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break;
            }
            Console.WriteLine(grade);



            int numbers = 100;
            int odd = 0;
            int even = 0;

            for (int i = 1; i <= numbers; i = i + 2)
            {
                odd = odd + i;
            }

            Console.WriteLine("홀수의 합= " + odd);



            for (int i = 2; i <= numbers; i = i + 2)
            {
                even = even + i;
            }

            Console.WriteLine("짝수의 합= " + even);


            int three = 0;

            for (int i = 3; i <= numbers; i = i + 3)
            {
                three = three + i;
            }

            string userid = "test";
            string password = "1232";

            int count = 10;

            for ( int i = count; i >= 0; i-- )
            {
                Console.WriteLine(i);
            }

            int number1 = 0;
            int number2 = 0;
            string readNumber1 = "";
            string readNumber2 = "";
            readNumber1 = Console.ReadLine();
            readNumber2 = Console.ReadLine();

            number1 = int.Parse (readNumber1);
            number2 = int.Parse (readNumber2);

            {
                Console.WriteLine(number1 + number2);
                Console.WriteLine(number1 - number2);
                Console.WriteLine(number1 * number2);
                Console.WriteLine(number1 / number2);
                Console.WriteLine(number1 % number2);

            }
            

        }
    }
}

