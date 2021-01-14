using System.Web.Mvc;
using Newtonsoft.Json;
using Abp.Web.Mvc.Authorization;
using Newtonsoft.Json.Linq;
using STEP.Customer;
using STEP.Forms;

namespace STEP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : STEPControllerBase
    {
        private readonly ICustomerAppService _customerAppService;
        private readonly IFormAppService _formAppService;
        public HomeController(ICustomerAppService customerAppService, IFormAppService formAppService)
        {
            _customerAppService = customerAppService;
            _formAppService = formAppService;
        }
        public ActionResult Index()
        {
            //CustomerDto custD = new CustomerDto();
            //var result = custD.SaveData();
            var x = GetFormAndData(Page.Customer, 1);
            return View(_customerAppService.GetAll());
        }
        public ActionResult Details(int id)
        {
            return View(id);
        }

        public ActionResult GetForm()
        {
            var data = "{\"display\": \"form\",\"settings\": {\"pdf\": {\"id\": \"1ec0f8ee - 6685 - 5d98 - a847 - 26f67b67d6f0\",\"src\": \"https://files.form.io/pdf/5692b91fd1028f01000407e3/file/1ec0f8ee-6685-5d98-a847-26f67b67d6f0\"}},\"components\": [{\"label\": \"Customer Name\",\"tableView\": true,\"key\": \"customerName\",\"type\": \"textfield\",\"input\": true},{\"label\": \"Phone Number\",\"tableView\": true,\"key\": \"phoneNumber\",\"type\": \"textfield\",\"input\": true},{\"label\": \"Email Address\",\"tableView\": true,\"key\": \"emailAddress\",\"type\": \"textfield\",\"input\": true},{\"label\": \"Street Address\",\"tableView\": true,\"key\": \"streetAddress\",\"type\": \"textfield\",\"input\": true},{\"label\": \"City\",\"tableView\": true,\"key\": \"city\",\"type\": \"textfield\",\"input\": true},{\"label\": \"Zip Code\",\"tableView\": true,\"key\": \"zipCode\",\"type\": \"textfield\",\"input\": true},{\"label\": \"Submit\",\"showValidations\": false,\"tableView\": false,\"key\": \"submit1\",\"type\": \"button\",\"input\": true}]}";
            var data1 = "{\"_id\": \"5aa316c59f3918304b469e82\",\"title\": \"Customer Load\",\"display\": \"form\",\"type\": \"form\",\"components\": [{\"label\": \"Customer Name\",\"tableView\": true,\"key\": \"customerName\",\"type\": \"textfield\",\"input\": true},{\"label\": \"Phone Number\",\"tableView\": true,\"key\": \"phoneNumber\",\"type\": \"textfield\",\"input\": true},{\"label\": \"Email Address\",\"tableView\": true,\"key\": \"emailAddress\",\"type\": \"textfield\",\"input\": true},{\"label\": \"Street Address\",\"tableView\": true,\"key\": \"streetAddress\",\"type\": \"textfield\",\"input\": true},{\"label\": \"City\",\"tableView\": true,\"key\": \"city\",\"type\": \"textfield\",\"input\": true},{\"label\": \"Zip Code\",\"tableView\": true,\"key\": \"zipCode\",\"type\": \"textfield\",\"input\": true},{\"type\": \"button\",\"label\": \"Submit\",\"key\": \"submit\",\"disableOnInvalid\": true,\"input\": true,\"tableView\": false}]}";
            return Json(JObject.Parse(data1), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetData(int id)
        {
            var model = _customerAppService.Get(id);
            var json = JsonConvert.SerializeObject(model);
            //var data = "[{\"_id\": \"5aa3156c9f3918403e469e7a\",\"data\": " + json + ",\"owner\": \"55673dc04f0405dd28205bb7\",\"access\": [  ],\"form\": \"5aa3153f9f3918b81d469e77\",\"_fvid\": 0,\"roles\": [  ],\"externalIds\": [  ],\"created\": \"2018-03-09T23:14:52.197Z\",\"_vid\": 0,\"modified\": \"2018-03-09T23:14:52.198Z\",\"project\": \"5692b91fd1028f01000407e3\"  }]";
            var data1 = "{\"data\": {\"customerName\": \"Kishan Bhatt\",\"phoneNumber\": \"234-567-8901\",\"streetAddress\": \"60 Absolute Ave\",  \"emailAddress\": \"bhattkishan009@gmail.com\",  \"city\": \"Mississauga\",  \"zipCode\": \"L4Z 0A9\",\"submit\": true}}";
            return Json(JArray.Parse(data1), JsonRequestBehavior.AllowGet);
        }

        private ViewResponse GetFormAndData(Page page, int id)
        {
            ViewResponse viewResponse = new ViewResponse(page, id, _formAppService, _customerAppService);
            var x = viewResponse.Form;
            var y = viewResponse.Data;
            return viewResponse;
        }
    }
}