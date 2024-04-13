
using System;
using System.Threading.Channels;

class SimpleCalculator
{
    static void Main()
    {

        // 함수를 왜 쓰는가?

        //Console

        // 반환 값이 없는 함수

        void Star() { }
        void Update() { }




        Console.WriteLine("Hello World!");
        Console.WriteLine("안녕하세요, 제 이름은 명진재입니다.");

        // Bpplean 타입

        bool isboy = true;
        Console.WriteLine(isboy);

        String myString = Console.ReadLine();
        Console.WriteLine(myString);
        int coinnumber = int.Parse(Console.ReadLine());

        // 주석 : 코드는 사람이 보는 것이기 때문에 설명을 달아둘 수 있다.
        // 연속으로 주석을 달아 둘 수 있다.

        // ctrl + k + c  : 일괄 주석 처리
        // ctrl + k + u  : 일괄 주석 처리 해제
        // alt를 누른상태로 마우스 커서 : 이동 일괄 처리 가능
        // 이동 하고 싶은 코드를 드래그 한 후 alt를 누른 상태로 키보드 화살표 위 아래 사용

        if (coinnumber == 1)
        {
            Console.WriteLine("왼손으로 휘두른다.");
        }
        if (coinnumber == 0)
        {
            Console.WriteLine("오른손으로 휘두른다.");
        }

        // 두 수를 비교를 해보도록 할게요.

        bool isFrontValueBiggerThanAfter = 10 > 25; // false
        bool isSame = 10 == 10;
        // bool 데이터 자료형에 !를 앞에 붙여 주면, true -> false, false -> true로 바뀐다.

        bool isSameAndBigger = 10 >= 15;

        // Quiz2. 다음 결과 값의 결과는 무엇이 나올까요?
        var number = 100;
        var resultB = !(number < 20);

        // Quiz3. a와 b룰 더한 결과가 n보다 크거나 같은지 리턴하는 함수를 만들어 보겠습니다.
        Console.WriteLine("불 확인 함수의 결과 값" + BooleanTypeAndOperator(3, 5, 7));
        {

        }
                {

        }

    }

    // Ctrl + M + M : 함수 접거나 피기


    static void Add(int a, int b)
    {
        
    }
    // 반환 값 함수의 이름()
    // {
    //    코드 블럭
    //    실제로 코드를 처리하는 부분을 코드 블럭이라 한다. { 열렸으면, } 닫혀야 합니다. EOF에러.
    // }

    // 반환 값....
    // 함수를 실행하고 나서 결과 값을 반환해주고 싶으면, void 대신 반환하고 싶은 데이터 타입(자료형)을 적어주면 된다.
    // 반환 값이 있는 함수는 반드시 해당 데이터를 return 해줘야 합니다.
    static bool BooleanTypeAndOperator(int a, int b, int n)
    {
        // 두 수를 더한 값이 n 보다 크거나 같으면 true를 리턴하고, 아니면 false를 리턴하도록 만드는 함수.
        if( a+b < n)
        {
            return true;
        }
        else                // a < b 일때 코드블럭 작성
        {
            return false;
        }
        
    }
}