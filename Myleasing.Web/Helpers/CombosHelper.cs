using Microsoft.AspNetCore.Mvc.Rendering;
using Myleasing.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myleasing.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        IEnumerable<SelectListItem> ICombosHelper.GetComboPropertyTypes()
        {
            var list = _dataContext.PropertyTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = $"{pt.Id}"

            }).OrderBy(pt => pt.Text)
                .ToList();
            list.Insert(0, new SelectListItem
            {

                Text = "Seleccione Tipo de Propiedad",
                Value = "0"
            });

            return list;
        }

    }
}