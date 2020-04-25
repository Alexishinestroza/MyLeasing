using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Myleasing.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPropertyTypes();
    }
}