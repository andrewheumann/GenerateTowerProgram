// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace GenerateTowerProgram
{
    public class GenerateTowerProgramOutputs: ResultsBase
    {
		/// <summary>
		/// The volume.
		/// </summary>
		[JsonProperty("Volume")]
		public double Volume {get;}


        
        /// <summary>
        /// Construct a GenerateTowerProgramOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public GenerateTowerProgramOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a GenerateTowerProgramOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public GenerateTowerProgramOutputs(double volume): base()
        {
			this.Volume = volume;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}