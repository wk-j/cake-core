using System;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Run {

    class NpmSettings : ToolSettings {

    }

    class NpmTool : Tool<NpmSettings> {
        public NpmTool(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IGlobber globber) : base(fileSystem, environment, processRunner, globber) {
        }

        public NpmTool(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools) : base(fileSystem, environment, processRunner, tools) {
        }

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