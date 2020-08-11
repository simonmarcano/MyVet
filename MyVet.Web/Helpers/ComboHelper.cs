using Microsoft.AspNetCore.Mvc.Rendering;
using MyVet.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Helpers
{
    public class ComboHelper : IComboHelper
    {
        private readonly DataContext _dataContext;

        public ComboHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboPetTypes()
        {
            //var list = new List<SelectListItem>();
            //foreach (var petType in _dataContext.PetTypes)
            //{
            //    list.Add(new SelectListItem
            //    {
            //        Text = petType.Name,
            //        Value = $"{petType.Id}"
            //    });
            //}

            var list = _dataContext.PetTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = $"{pt.Id}"
            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Selecciona un Tipo de Mascota]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboServiceTypes()
        {
            var list = _dataContext.ServiceTypes.Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = p.Id.ToString()
            }).OrderBy(p => p.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a service type...)",
                Value = "0"
            });

            return list;
        }
    }
}
