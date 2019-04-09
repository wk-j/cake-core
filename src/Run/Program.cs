using System;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Run {

    class NpmSettings : ToolSettings {

    }

    class NpmTool : Tool<NpmSettings> {
        protected override IEnumerable<string> GetToolExecutableNames() {
            return new[] { "npm" };
        }

        protected override string GetToolName() {
            return "npm";
        }
    }

    class Program {
        static void Main(string[] args) {


        }
    }
}