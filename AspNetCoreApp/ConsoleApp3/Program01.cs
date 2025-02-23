using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program01
    {
        public void Run()
        {
            Console.WriteLine("ASP NET CORE - Options - note");

            Note();
        }

        private void Note()
        {
            /*
                OptionsServiceCollectionExtensions
                - AddOptions()
                    : IOptions<TOptions> = is singleton service
                        + UnnamedOptionsManager<TOptions>
                    : IOptionsSnapshot<TOptions> = is scoped service
                        + OptionsManager<TOptions>
                    : IOptionsMonitor<TOptions> = is singleton service
                        + OptionsMonitor<TOptions>
                    : IOptionsMonitorCache<TOptions> = is singleton service
                    : IOptionsFactory<TOptions>:Create(...) = to create options instance and to configure options
                        + OptionsFactory<TOptions>

                - ConfigureOptions()
                    : IConfigureOptions<TOptions>:Configure(...) = to configure options
                        + ConfigureOptions<TOptions>
                    : IConfigureNamedOptions<TOptions>:Configure(...) = to configure options
                        + ConfigureNamedOptions<TOptions>
                    : IPostConfigureOptions<TOptions>:PostConfigure(...) = to post configure options
                        + PostConfigureOptions<TOptions>
                    : IValidateOptions<TOptions>:Validate(...) = to validate options
                        + ValidateOptions<TOptions>

                - Configure<TOptions>(...)
                    = 當此方法呼叫時，
                    = 只是將 ConfigureNamedOptions<TOptions> 物件增加進服務容器，而並未設定選項類別(委託沒有被呼叫)。
                    = 若呼叫多次，則會加進多個實例。
                - PostConfigure<TOptions>(...)
                - ConfigureAll<TOptions>(...)
                - PostConfigureAll<TOptions>(...)
             */

            /*
               to process options:                 to create options:           to encapsulate options:
               IConfigureOptions<TOptions>      -> IOptionsFactory<TOptions> -> IOptions<TOptions>
               IConfigureNamedOptions<TOptions> ->                           -> IOptionsSnapshot<TOptions>
               IPostConfigureOptions<TOptions>  ->                           -> IOptionsMonitor<TOptions>
               IValidateOptions<TOptions>       ->                           -> IOptionsMonitorCache<TOptions>
             */
        }
    }
}
