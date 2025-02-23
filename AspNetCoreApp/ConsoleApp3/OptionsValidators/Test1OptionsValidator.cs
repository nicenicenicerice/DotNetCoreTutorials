using ConsoleApp3.Options;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OptionsValidators
{
    internal class Test1OptionsValidator : IValidateOptions<Test1Options>
    {
        public ValidateOptionsResult Validate(string? name, Test1Options options)
        {
            if (options == null)
            {
                ValidateOptionsResult.Fail($"{name} options can't be null.");
            }

            // to validate ...

            return ValidateOptionsResult.Success;
        }
    }
}
