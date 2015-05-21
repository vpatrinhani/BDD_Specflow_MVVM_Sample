using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.UIBusiness.ViewModel;

namespace Calculator.WebApp.Controllers
{
    public class ArithmeticController : Controller
    {
        //
        // GET: /Arithmetic/

        [HttpGet]
        public ActionResult Index()
        {
            return View(new ArithmeticViewModel());
        }

        [HttpPost]
        public ActionResult Index(ArithmeticViewModel viewModel, double? selectedNumber, string selectedAction)
        {
            if (selectedNumber.HasValue)
            {
                viewModel.UpdateNumber = selectedNumber ?? default(double);
            }

            if (!string.IsNullOrEmpty(selectedAction))
            {
                switch (selectedAction)
                {
                    case "+":
                        viewModel.RunAdd();
                        break;
                    case "-":
                        viewModel.RunSubtract();
                        break;
                    case "÷":
                        viewModel.RunDivide();
                        break;
                    case "x":
                        viewModel.RunMultiply();
                        break;
                    case "=":
                        viewModel.RunEquals();
                        break;
                    case "C":
                        viewModel.RunClear();
                        break;
                }
            }

            ModelState.Clear();
            return View(viewModel);
        }
    }
}
