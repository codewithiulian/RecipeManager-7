using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Services
{
    public interface IRecipeService
    {
        Recipe Create(Recipe recipe);
        Recipe Get(int id);
        List<Recipe> List();
        Recipe Update(Recipe recipe);
        void Delete(int id);
    }
}
