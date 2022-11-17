using Microsoft.AspNetCore.Mvc;

namespace Bank_Asp.Controllers
{

    public class BankController : Controller
    {
        [Route("/"), HttpGet]
        public IActionResult Index()
        {
            Response.StatusCode = 200;
            return Content("Welcome to the Best Bank");
        }

        [Route("/account-details"), HttpGet]
        public JsonResult AccountDetails()
        {
            JsonModel jsonModel = new JsonModel() { AccountNumber = 1000, AccountHolderName = "Salim", CurrentBalance = 5000 };

            Response.StatusCode = 200;
            return Json(jsonModel);
        }

        [Route("/account-statement"), HttpGet]
        public VirtualFileResult AccountStatement()
        {
            Response.StatusCode = 200;
            return File("LaimecheSalimDP.pdf", "application/pdf");
        }

        [Route("/get-current-balance/{accountNumber:regex(^\\d{{4}}$)}"), HttpGet]
        public IActionResult GetCurrentBalanceOnThisAccount()
        {
            //echec here, i don't find how to success this endpoint
            
            var accountModel = Convert.ToInt16(Request.Query.FirstOrDefault());

            if (accountModel is not 1001)
            {
                Response.StatusCode = 404;
                return Content("Account number should be : 1001");
            }
            else
            {
               
                Response.StatusCode = 200;
                return Json(accountModel);
            }
        }
    }
}
