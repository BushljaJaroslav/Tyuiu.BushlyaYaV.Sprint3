using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BushlyaYaV.Sprint3.Task3.V9.Lib
{
    public class DataService : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char ch in value)
            {
                if (char.IsDigit(ch))
                {
                    value = value.Replace(ch, item);
                }
            }
            return value;
        }
    }
}
