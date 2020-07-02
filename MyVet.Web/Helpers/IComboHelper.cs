using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MyVet.Web.Helpers
{
    public interface IComboHelper
    {
        IEnumerable<SelectListItem> GetComboPetTypes();
    }
}