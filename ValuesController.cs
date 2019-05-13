using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IGI_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace IGI_6.Controllers
{
    public class ValuesController : ControllerBase
    {
        Repository repo;

        public ValuesController(ApplicationContext context)
        {
            repo = new Repository(context);
        }

        [HttpGet]
        [Route("api/worker")]
        public ActionResult GetWorkers()
        {
            var val = repo.GetWorkers();
            return new JsonResult(val);
        }
        [HttpGet]
        [Route("api/order")]
        public ActionResult GetOrders()
        {
            var val = repo.GetOrders();
            return new JsonResult(val);
        }
        [HttpGet]
        [Route("api/furniture")]
        public ActionResult GetFurnitures()
        {
            var val = repo.GetFurnitures();
            return new JsonResult(val);
        }
        [HttpGet]
        [Route("api/client")]
        public ActionResult GetClients()
        {
            var val = repo.GetClients();
            return new JsonResult(val);
        }

        [HttpPost]
        [Route("api/AddWorker")]
        public ActionResult AddWorker(Worker worker)
        {
            repo.AddWorker(worker);
            return new JsonResult(repo.GetWorkers());
        }
        [HttpPost]
        [Route("api/AddOrder")]
        public ActionResult AddOrder(Order order, string clientName, string furnitureName, string workerName)
        {
            order.Client = repo.GetClientByName(clientName);
            order.Furniture = repo.GetFurnitureByName(furnitureName);
            order.Worker = repo.GetWorkerByName(workerName);
            repo.AddOrder(order);
            return new JsonResult(repo.GetOrders());
        }
        [HttpPost]
        [Route("api/AddFurniture")]
        public ActionResult AddFurniture(Furniture furniture)
        {
            repo.AddFurniture(furniture);
            return new JsonResult(repo.GetFurnitures());
        }
        [HttpPost]
        [Route("api/AddClient")]
        public ActionResult AddClient(Client client)
        {
            repo.AddClient(client);
            return new JsonResult(repo.GetClients());
        }

        [HttpDelete]
        [Route("api/worker")]
        public ActionResult DelWorker(int id)
        {
            repo.RemoveWorker(id);
            return new JsonResult(repo.GetWorkers());
        }
        [HttpDelete]
        [Route("api/order")]
        public ActionResult DelOrder(int id)
        {
            repo.RemoveOrder(id);
            return new JsonResult(repo.GetOrders());
        }
        [HttpDelete]
        [Route("api/furniture")]
        public ActionResult DelFurniture(int id)
        {
            repo.RemoveFurniture(id);
            return new JsonResult(repo.GetFurnitures());
        }
        [HttpDelete]
        [Route("api/client")]
        public ActionResult DelClient(int id)
        {
            repo.RemoveClient(id);
            return new JsonResult(repo.GetClients());
        }

        [HttpPut]
        [Route("api/worker")]
        public ActionResult EditWorker(Worker worker)
        {
            if (ModelState.IsValid)
            {
                repo.EditWorker(worker);
            }
            return new JsonResult(repo.GetWorkers());
        }
        [HttpPut]
        [Route("api/order")]
        public ActionResult EditOrder(Order order, string clientName, string furnitureName, string workerName)
        {
            if (ModelState.IsValid)
            {
                order.Client = repo.GetClientByName(clientName);
                order.Furniture = repo.GetFurnitureByName(furnitureName);
                order.Worker = repo.GetWorkerByName(workerName);
                repo.EditOrder(order);
            }
            return new JsonResult(repo.GetOrders());
        }
        [HttpPut]
        [Route("api/furniture")]
        public ActionResult EditFurniture(Furniture furniture)
        {
            if (ModelState.IsValid)
            {
                repo.EditFurniture(furniture);
            }
            return new JsonResult(repo.GetFurnitures());
        }
        [HttpPut]
        [Route("api/client")]
        public ActionResult EditClient(Client client)
        {
            if (ModelState.IsValid)
            {
                repo.EditClient(client);
            }
            return new JsonResult(repo.GetClients());
        }
    }
}
