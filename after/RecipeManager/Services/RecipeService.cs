﻿using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly ApplicationDbContext _db;

        public RecipeService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Recipe Create(Recipe recipe)
        {
            recipe.DateCreated = DateTime.Now;
            recipe.DateUpdated = DateTime.Now;

            var newRecipe = _db.Recipes.Add(recipe);
            _db.SaveChanges();

            return newRecipe.Entity;
        }

        public void Delete(int id)
        {
            var recipe = _db.Recipes.Find(id);

            if (recipe != null)
            {
                _db.Remove(recipe);
                _db.SaveChanges();
            }
        }

        public Recipe Get(int id)
        {
            return _db.Recipes.Find(id);
        }

        public List<Recipe> List()
        {
            return _db.Recipes.OrderByDescending(o => o.DateUpdated).ToList();
        }

        public Recipe Update(Recipe recipe)
        {
            var dbRecipe = _db.Recipes.Find(recipe.Id);

            if (dbRecipe != null)
            {
                dbRecipe = recipe;
                dbRecipe.DateUpdated = DateTime.Now;

                _db.SaveChanges();
            }
            return dbRecipe;
        }
    }
}
