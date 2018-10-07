using System;

namespace Andoromeda.TestFx.Eos
{
    public class ProcessExitedWithNonZeroException : Exception
    {
        public ProcessExitedWithNonZeroException(int exitCode, string errorMessage)
        {
            this.ExitCode = exitCode;
            this.ErrorMessage = errorMessage;
        }

        public int ExitCode { get; private set; }

        public string ErrorMessage { get; private set; }
    }
}
