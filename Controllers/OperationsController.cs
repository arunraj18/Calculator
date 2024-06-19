using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculator.Controllers
{
    public class OperationsController : Controller
    {
        OperationModel? operationModel;
        public IActionResult operationAdd()
        {
            OperationModel o = new OperationModel();
            o.x = 22;
            o.y = 33;
            o.z = o.x + o.y;
            return View(o);
        }
        //get
        [HttpGet]

        public IActionResult OperationAll()
        {
            operationModel = new OperationModel();
            return View(operationModel);

        }

        //post method
        [HttpPost]

        public IActionResult OperationAll(OperationModel obj)
        {
            operationModel = new OperationModel();
            operationModel.x = obj.x;
            operationModel.y = obj.y;
            operationModel.operation = obj.operation;
            switch (operationModel.operation)
            {
                case "add":
                    operationModel.Addition();
                    break;
                case "subtract":
                    operationModel.Subtract();
                    break;
                case "multiply":
                    operationModel.Multiply();
                    break;
                case "divide":
                    operationModel.Division();
                    break;

            }

            return View(operationModel);
        }
    }
}