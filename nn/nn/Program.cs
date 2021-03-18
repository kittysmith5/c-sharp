using System;
/*
 支持，大家已了解 C# 语言中的 if 语句和循环构造。看看能否编写 C# 代码，计算 1 到 20 中所有可被 3 整除的整数的总和。 下面提供了一些提示：

% 运算符可用于获取除法运算的余数。
if 语句中的条件可用于判断是否应将数字计入总和。
for 循环有助于对 1 到 20 中的所有数字重复执行一系列步骤。
亲自试一试吧。 然后，看看自己是怎么做到的。 提示：你应获取的答案为 63。*/
namespace nn
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i < 21; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"sum is {sum}");
        }
    }
}
