using System.Collections.Generic;
using System.IO;
using cmd.Commands;

namespace cmd.Runner
{
    public interface IRunner
    {
        StreamReader Run(IRunOptions runOptions);
        string BuildArgument(Arguments.Argument argument);
        IDictionary<string, string> EnvironmentVariables { get; set; }
        ICommando GetCommand();
    }
}