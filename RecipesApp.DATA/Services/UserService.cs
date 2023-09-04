using Amazon.Runtime.Internal.Util;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RecipesApp.DATA.Database;
using RecipesApp.DATA.Entities;
using RecipesApp.DATA.Models;
using RecipesApp.DATA.Repositories;
using RecipesApp.DATA.Repositories.Interfaces;
using RecipesApp.DATA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DATA.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        //Get all users
        public async Task<List<UserModel>> GetAllUsers()
        {
            var models = new List<UserModel>();
            try
            {
                //Get all users from user repository
                var entities = await _repository.GetAllUsers();
                //Validate and map entities to models
                foreach (var entity in entities)
                    models.Add(MapEntityToModel(entity));
            }
            catch (Exception ex) {  }
            return models;
        }
        //Get user by id
        public async Task<UserModel> GetUserById(string id)
        {
            //Create new model, fetch entity from db and map to model
            var model = new UserModel();
            try
            {
                var entity = await _repository.GetUserById(id);
                model = MapEntityToModel(entity);
            }
            catch(Exception ex) { }
            return model;
        }
        //Create new user
        public async Task<bool> CreateUser(UserModel user)
        {
            try
            {
                var entity = MapModelToEntity(user);
                await _repository.CreateUser(entity);
            }
            catch(Exception ex) { return false; }
            return true;
        }
        //Update user
        public async Task<UserModel> UpdateUser(UserModel user)
        {
            var model = new UserModel();
            try
            {
                var entity = MapModelToEntity(user);
                var result = await _repository.UpdateUser(entity);
                model = MapEntityToModel(result);
            }
            catch { }
            return model;
        }
        //Delete user
        public async Task<bool> DeleteUser(string id)
        {
            var result = false;
            try
            {
                result = (await _repository.DeleteUser(id) != null) ? true : false;
            }
            catch { return false; }
            return result;
        }

        #region Mapping
        private UserEntity MapModelToEntity(UserModel model)
        {
            var entity = new UserEntity();
            if (model != null)
            {
                entity.UserName = model.UserName;
                entity.Name = model.Name;
                entity.Age = model.Age;
            }
            return entity;
        }
        private UserModel MapEntityToModel(UserEntity entity)
        {
            var model = new UserModel();
            if (entity != null)
            {
                model.Id = entity.Id;
                model.UserName = entity.UserName;
                model.Name = entity.Name;
                model.Age = entity.Age;
            }
            return model;
        }
        #endregion
    }
}
