using System;
using Simple_ml_app_01ML.Model;

namespace simple_ml_app_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput()
            {
                Col0 = "This is  good restaurant."
            };
            ModelOutput result = ConsumeModel.Predict(input);
            string sentiment = result.Prediction == "1" ? "Positive" : "Negative";
            Console.WriteLine($"Text : {input.Col0}\nSentiment : {sentiment}");
        }
    }
}
