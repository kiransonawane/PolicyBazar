﻿//using Quote.Api.Models;
//using Quote.Application.Interfaces;
//using Quote.Core.Entities;
//using Quote.Logging;
//using Microsoft.AspNetCore.Mvc;
//using System.Data.SqlClient;

//namespace Quote.Api.Controllers
//{
//    public class ContactController : BaseApiController
//    {
//        private readonly IUnitOfWork _unitOfWork;

//        public ContactController(IUnitOfWork unitOfWork)
//        {
//            this._unitOfWork = unitOfWork;
//        }

//        [HttpGet]
//        public async Task<ApiResponse<List<Contact>>> GetAll()
//        {
//            var apiResponse = new ApiResponse<List<Contact>>();

//            try
//            {
//                var data = await _unitOfWork.Contacts.GetAllAsync();
//                apiResponse.Success = true;
//                apiResponse.Result = data.ToList();
//            }
//            catch (SqlException ex)
//            {
//                apiResponse.Success = false;
//                apiResponse.Message = ex.Message;
//                Logger.Instance.Error("SQL Exception:", ex);
//            }
//            catch (Exception ex)
//            {
//                apiResponse.Success = false;
//                apiResponse.Message = ex.Message;
//                Logger.Instance.Error("Exception:", ex);
//            }

//            return apiResponse;
//        }

//        [HttpGet("{id}")]
//        public async Task<ApiResponse<Contact>> GetById(int id)
//        {

//            var apiResponse = new ApiResponse<Contact>();

//            try
//            {
//                var data = await _unitOfWork.Contacts.GetByIdAsync(id);
//                apiResponse.Success = true;
//                apiResponse.Result = data;
//            }
//            catch (SqlException ex)
//            {
//                apiResponse.Success = false;
//                apiResponse.Message = ex.Message;
//                Logger.Instance.Error("SQL Exception:", ex);
//            }
//            catch (Exception ex)
//            {
//                apiResponse.Success = false;
//                apiResponse.Message = ex.Message;
//                Logger.Instance.Error("Exception:", ex);
//            }

//            return apiResponse;
//        }

//        [HttpPost]
//        public async Task<ApiResponse<string>> Add(Contact contact)
//        {
//            var apiResponse = new ApiResponse<string>();

//            try
//            {
//                var data = await _unitOfWork.Contacts.AddAsync(contact);
//                apiResponse.Success = true;
//                apiResponse.Result = data;
//            }
//            catch (SqlException ex)
//            {
//                apiResponse.Success = false;
//                apiResponse.Message = ex.Message;
//                Logger.Instance.Error("SQL Exception:", ex);
//            }
//            catch (Exception ex)
//            {
//                apiResponse.Success = false;
//                apiResponse.Message = ex.Message;
//                Logger.Instance.Error("Exception:", ex);
//            }

//            return apiResponse;
//        }

//        [HttpPut]
//        public async Task<ApiResponse<string>> Update(Contact contact)
//        {
//            var apiResponse = new ApiResponse<string>();

//            try
//            {
//                var data = await _unitOfWork.Contacts.UpdateAsync(contact);
//                apiResponse.Success = true;
//                apiResponse.Result = data;
//            }
//            catch (SqlException ex)
//            {
//                apiResponse.Success = false;
//                apiResponse.Message = ex.Message;
//                Logger.Instance.Error("SQL Exception:", ex);
//            }
//            catch (Exception ex)
//            {
//                apiResponse.Success = false;
//                apiResponse.Message = ex.Message;
//                Logger.Instance.Error("Exception:", ex);
//            }

//            return apiResponse;
//        }

//        [HttpDelete]
//        public async Task<ApiResponse<string>> Delete(int id)
//        {
//            var apiResponse = new ApiResponse<string>();

//            try
//            {
//                var data = await _unitOfWork.Contacts.DeleteAsync(id);
//                apiResponse.Success = true;
//                apiResponse.Result = data;
//            }
//            catch (SqlException ex)
//            {
//                apiResponse.Success = false;
//                apiResponse.Message = ex.Message;
//                Logger.Instance.Error("SQL Exception:", ex);
//            }
//            catch (Exception ex)
//            {
//                apiResponse.Success = false;
//                apiResponse.Message = ex.Message;
//                Logger.Instance.Error("Exception:", ex);
//            }

//            return apiResponse;
//        }
//    }
//}
