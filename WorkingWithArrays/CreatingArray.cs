using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        public static int[] CreateEmptyArrayOfIntegers()
        {
            return Array.Empty<int>();
        }

        public static bool[] CreateEmptyArrayOfBooleans()
        {
            return Array.Empty<bool>();
        }

        public static string[] CreateEmptyArrayOfStrings()
        {
            return Array.Empty<string>();
        }

        public static char[] CreateEmptyArrayOfCharacters()
        {
            return Array.Empty<char>();
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            return Array.Empty<double>();
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            return Array.Empty<float>();
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            return Array.Empty<decimal>();
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            return new int[10];
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            return new bool[20];
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            return new string[5];
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            return new char[15];
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            return new double[18];
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            return new float[100];
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            return new decimal[1000];
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            return new[] { 123456 };
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            return new[] { 1111111, 9999999 };
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            return new[] { 0, 4234, 3845, 2942, 1104, 9794, 923943, 7537, 4162, 10134 };
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            return new[] { true };
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            return new[] { true, false, true, false, true };
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            return new[] { false, true, true, false, true, true, false };
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            return new[] { "one" };
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            return new[] { "one", "two", "three" };
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            return new[] { "one", "two", "three", "four", "five", "six" };
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            return new[] { 'a' };
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            return new[] { 'a', 'b', 'c' };
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            return new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            return new[] { 1.12 };
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            return new[] { 1.12, 2.23, 3.34, 4.45, 5.56 };
        }

        public static double[] CreateDoubleWithNineElements()
        {
            return new[] { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            return new[] { 123456789.123456f };
        }

        public static float[] CreateFloatWithThreeElements()
        {
            return new[] { 10_000_00.12_34_56f, 222_333_4444.12_34_56f, 9999.999999f };
        }

        public static float[] CreateFloatWithFiveElements()
        {
            return new[] { 1.0123f, 20.012345f, 300.01234567f, 4_000.01234567f, 5_00000.01234567f };
        }

        public static float[] CreateFloatWithSevenElements()
        {
            return new[] { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f, 7.7f };
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            return new[] { 10_000.12_34_56m };
        }

        public static decimal[] CreateDecimalArrayWithThreeElements()
        {
            return new[] { 1_000.01m, 2_000.02m, 3_000.03m };
        }

        public static decimal[] CreateDecimalArrayWithFiveElements()
        {
            return new[] { 1_000.12_34m, 10_0000.23_45m, 100_000.34_56m, 1_000_000.4567_89m, 10000000.5678901m };
        }

        public static decimal[] CreateDecimalArrayWithTenElements()
        {
            return new[]
            {
                10.1m, 20.2m, 30.3m, 40.4m, 50.5m, 60.6m, 70.7m, 80.8m, 90.9m, 100.1m,
            };
        }

        public static decimal[] CreateDecimalArrayWithNineElements()
        {
            return new[]
            {
                10.12_21_12M, 200.23_32_23M, 3_000.34_43_34M, 40_000.45_54_45M, 500_000.56_65_56M, 6_000_000.67_76_67M, 70_000_000.78_87_78M, 800_000_000.89_98_89M, 9_000_000_000.91_19_91M,
            };
        }
    }
}
