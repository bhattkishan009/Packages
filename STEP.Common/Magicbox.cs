//using STEP.Forms;
//using System;

//namespace STEP.Common
//{
//    public static class Magicbox
//    {
//        public static string GetFormData(Page page, int id)
//        {
//            ViewResponse viewResponse = new ViewResponse(page, id);

//            //viewResponse.
//            return string.Empty;
//        }

//        public static string GetFormAndJson(int id, Page page)
//        {
//            return "";
//        }

//        private static string GetJsonFromDatabase()
//        {

//        }
//    }

//    public enum Page
//    {

//    }

//    public class ViewResponse
//    {
//        public Page Page { get; set; }
//        public int Id { get; set; }
//        private IFormAppService _formAppService;

//        public string Data { get; private set; }
//        public string Form
//        {
//            get
//            {
//                return _formAppService.Get((int)Page);
//            }
//        }


//        public ViewResponse(Page page, int id, IFormAppService formAppService)
//        {
//            Page = page;
//            Id = id;
//            _formAppService = formAppService;
//        }

//        public string GetFormData()
//        {
//            _formAppService.Get()
//            return "";
//        }
//    }
//}
