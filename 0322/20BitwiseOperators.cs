using System;


namespace Basic
{
    class Object
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i; // i�� ���� �ڽ��Ͽ� o�� �����մϴ�
            i = i + 10; // i�� ���� �ٲߴϴ�. o�� ������ �ʽ��ϴ�.
            int j = (int)o; // o�� ���� ��ڽ��Ͽ� j�� �����մϴ�.
                            // i�� ���� ���ص� o�� ����� ���� ������� �ʽ��ϴ�.
            Console.WriteLine("The value-type value i = {0}", i);
            Console.WriteLine("The object-type value o = {0}", o);
            Console.WriteLine("The value-type value j = {0}", j);
            object p = o;
            o = 100;
            Console.WriteLine("The object-type value o = {0}", o);
            Console.WriteLine("The object-type value p = {0}", p);

        }
    }
}


