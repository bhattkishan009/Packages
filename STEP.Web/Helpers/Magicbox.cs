using Abp.Application.Services.Dto;
using Newtonsoft.Json;
using STEP.Customer;
using STEP.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace STEP.Web
{
    //public static class Magicbox
    //{
    //    public static string GetData(Page page, int id)
    //    {
    //        // get list of all DTOs
    //        var listOfDtos = (
    //                from domainAssembly in AppDomain.CurrentDomain.GetAssemblies()
    //                from assemblyType in domainAssembly.GetTypes()
    //                where typeof(EntityDto).IsAssignableFrom(assemblyType)
    //                select assemblyType).ToArray();

    //        foreach (var type in listOfDtos)
    //        {
    //            Dto dto = (Dto)((int)page);
    //            object result = null;

    //            // found a match, now call GetData method
    //            if (type.Name == dto.ToString())
    //            {
    //                MethodInfo methodInfo = type.GetMethod("GetData");

    //                try
    //                {
    //                    object[] args = new object[] { MyFirstParmInt, MySecondParmString, myThirdParmOther };

    //                    object classInstance = Activator.CreateInstance(type, null);

    //                    object[] parametersArray = new object[] { id };
    //                    result = methodInfo.Invoke(classInstance, parametersArray);
    //                }
    //                catch (Exception ex)
    //                {
    //                    throw new Exception($"GetData function not setup properly in {type.Name}.");
    //                }

    //                return JsonConvert.SerializeObject(result);
                        
    //            }
    //        }


    //        return string.Empty;
    //    }
    //}

    public enum Page
    {
        Customer = 1
    }

    public enum Dto
    {
        CustomerDto = 1
    }

    public class ViewResponse
    {
        private Page _page { get; set; }
        private int _id { get; set; }
        private IFormAppService _formAppService;
        private ICustomerAppService _customerAppService;

        public string Data {
            get
            {
                return GetData(_page, _id);
            }
        }
        public string Form
        {
            get
            {
                return JsonConvert.SerializeObject(_formAppService.Get((int)_page));
            }
        }


        public ViewResponse(Page page, int id, IFormAppService formAppService, ICustomerAppService customerAppService)
        {
            _page = page;
            _id = id;
            _formAppService = formAppService;
            _customerAppService = customerAppService;
        }

        private string GetData(Page page, int id)
        {
            // get list of all DTOs
            var listOfDtos = (
                    from domainAssembly in AppDomain.CurrentDomain.GetAssemblies()
                    from assemblyType in domainAssembly.GetTypes()
                    where typeof(EntityDto).IsAssignableFrom(assemblyType)
                    select assemblyType).ToArray();

            foreach (var type in listOfDtos)
            {
                Dto dto = (Dto)((int)page);
                object result = null;

                // found a match, now call GetData method
                if (type.Name == dto.ToString())
                {
                    MethodInfo methodInfo = type.GetMethod("GetData");

                    try
                    {
                        object[] args = new object[] { _customerAppService };

                        object classInstance = Activator.CreateInstance(type, args);

                        object[] parametersArray = new object[] { id };
                        result = methodInfo.Invoke(classInstance, parametersArray);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"GetData function not setup properly in {type.Name}.");
                    }

                    return JsonConvert.SerializeObject(result);

                }
            }


            return string.Empty;
        }
    }
}