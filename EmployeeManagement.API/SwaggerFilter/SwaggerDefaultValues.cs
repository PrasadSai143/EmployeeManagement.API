using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace EmployeeManagement.API.SwaggerFilter
{
    public class SwaggerDefaultValues : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var apiDescription = context.ApiDescription;
            operation.Deprecated |= apiDescription.IsDeprecated();

            if (operation.Parameters == null)
                return;
            foreach (var paramerter in operation.Parameters)
            {
                var description = apiDescription.ParameterDescriptions.FirstOrDefault(p => p.Name == paramerter.Name);
                if (paramerter.Description == null)
                    paramerter.Description = description.ModelMetadata?.Description;
                if (paramerter.Schema.Default == null && description.DefaultValue != null)
                    paramerter.Schema.Default = new OpenApiString(description.DefaultValue.ToString());

                paramerter.Required |= description.IsRequired;
            }
        }
    }
}
