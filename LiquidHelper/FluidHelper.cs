using Fluid;
using Fluid.Values;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidHelper
{

    public static class FluidHelper
    {
        public static string FluidMapper(string input, string sourceModel)
        {
            IFluidTemplate template;
            TemplateContext context;
            var options = new TemplateOptions();
            options.MemberAccessStrategy.Register<JObject, object>((source, name) => source[name]);
            options.ValueConverters.Add(x => x is JObject o ? new ObjectValue(o) : null);
            options.ValueConverters.Add(x => x is JValue v ? v.Value : null);
            template = new FluidParser().Parse(sourceModel.ToLower());
            context = new TemplateContext(JObject.Parse(input.ToLower()), options);
            var response = template.Render(context);
            return response;
        }
    }

}
