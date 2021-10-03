using Fluid;
using Fluid.Values;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidConsoleApp
{
    public static class FluidHelper
    {
        public static string FluidMapper(string input, string sourceModel)
        {
            IFluidTemplate template;
            TemplateContext context;
            var options = new TemplateOptions();

            //// When a property of a JObject value is accessed, try to look into its properties
            //options.MemberAccessStrategy.Register<JObject, object>((source, name) => source[name]);

            //// Convert JToken to FluidValue
            //options.ValueConverters.Add(x => x is JObject o ? new ObjectValue(o) : null);
            //options.ValueConverters.Add(x => x is JValue v ? v.Value : null);

            options.MemberAccessStrategy.Register<JObject, object>((source, name) => source[name]);

            options.ValueConverters.Add(x => x is JObject o ? new ObjectValue(o) : null);
            /// options.ValueConverters.Add(x => x is JToken o ? new ObjectValue(o) : null);
            //options.ValueConverters.Add(x => x is JArray o ? new ArrayValue(o.Select(c=>new ObjectValue(c))) : null);

            options.ValueConverters.Add(x => x is JValue v ? v.Value : null);


            template = new FluidParser().Parse(sourceModel);
            context = new TemplateContext(JObject.Parse(input), options);
            var response = template.Render(context);
            return response;
        }
    }

}
