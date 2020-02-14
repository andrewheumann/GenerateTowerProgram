using Elements;
using Elements.Geometry;
using System.Collections.Generic;

namespace GenerateTowerProgram
{
      public static class GenerateTowerProgram
    {
        /// <summary>
        /// The GenerateTowerProgram function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A GenerateTowerProgramOutputs instance containing computed results and the model with any new elements.</returns>
        public static GenerateTowerProgramOutputs Execute(Dictionary<string, Model> inputModels, GenerateTowerProgramInputs input)
        {
            /// Your code here.
            var height = 1.0;
            var volume = input.Length * input.Width * height;
            var output = new GenerateTowerProgramOutputs(volume);
            var rectangle = Polygon.Rectangle(input.Length, input.Width);
            var mass = new Mass(rectangle, height);
            output.model.AddElement(mass);
            return output;
        }
      }
}