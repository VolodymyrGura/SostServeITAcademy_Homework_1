namespace SostServeITAcademy_Homework_1
{
    public interface IValidatable
    {
        int GetIntegerInput(string inputQuery, int min, int max);

        double GetDoubleInput(string inputQuery, double min, double max);

        string GetStringInput(string inputQuery);
    }
}
