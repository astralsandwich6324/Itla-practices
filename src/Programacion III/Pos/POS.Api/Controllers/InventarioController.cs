using Microsoft.AspNetCore.Mvc;
using POS.Api.Modelos.Response;
using POS.Api.Modelos;
using POS.Api.Data;
using POS.Api.Modelos.Request;


namespace POS.Api.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class InventarioController : Controller
    {
        //Obtener registros, este metodo sirve para regresar todos los ele-
        //mentos
        [HttpGet]
        public IActionResult Get()
        {
            Response<List<Inventory>> oResponse = new Response<List<Inventory>>();

            try
            {

            
            using (Contexto db = new Contexto())
            {
                var lst = db.InventoryDB.ToList();
                oResponse.Exito = 1;
                oResponse.Data = lst;
            }

            }
            catch(Exception ex)
            {
                oResponse.Mensaje = ex.Message;
            }
            return Ok(oResponse);
        }

        //Este es para un solo elemento, para regresar un solo elemento-
        //y asi funciona con el Eliminar.

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            Response<Inventory> oResponse = new Response<Inventory>();

            try
            {


                using (Contexto db = new Contexto())
                {
                    var lst = db.InventoryDB.Find(Id);
                    oResponse.Exito = 1;
                    oResponse.Data = lst;
                }

            }
            catch (Exception ex)
            {
                oResponse.Mensaje = ex.Message;
            }
            return Ok(oResponse);
        }

        //Ingresar registros
        [HttpPost]
        public IActionResult Add(InventoryRequest model)
        {
            Response<object> oResponse = new Response<object>();

            try
            {
                using (Contexto db = new Contexto())
                {
                    Inventory oInventory = new Inventory();
                    oInventory.Name = model.Name;
                    oInventory.Stock = model.Stock;
                    oInventory.Estado = model.Estado;
                    oInventory.FechaCaducidad = model.FechaCaducidad;
                    oInventory.Fecha = model.Fecha;
                    oInventory.BasePrice = model.BasePrice;
                    oInventory.Description = model.Description;
                    oInventory.ProvedorId = model.ProvedorId;
                    db.InventoryDB.Add(oInventory);
                    db.SaveChanges();
                    oResponse.Exito = 1;
                }

            }
            catch (Exception ex)
            {
                oResponse.Mensaje = ex.Message;
            }
            return Ok(oResponse);
        
        }

        //Editar 
        [HttpPut]
        public IActionResult Edit(InventoryRequest model)
        {
            Response<object> oResponse = new Response<object>();

            try
            {
                using (Contexto db = new Contexto())
                {
                    Inventory oInventory = db.InventoryDB.Find(model.Id);
                    oInventory.Name = model.Name;
                    oInventory.Stock = model.Stock;
                    oInventory.Estado = model.Estado;
                    oInventory.FechaCaducidad = model.FechaCaducidad;
                    oInventory.Fecha = model.Fecha;
                    oInventory.BasePrice = model.BasePrice;
                    oInventory.Description = model.Description;
                    oInventory.ProvedorId = model.ProvedorId;
                    db.Entry(oInventory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    //db.InventoryDB.Update(oInventory);
                    db.SaveChanges();
                    oResponse.Exito = 1;
                }

            }
            catch (Exception ex)
            {
                oResponse.Mensaje = ex.Message;
            }
            return Ok(oResponse);

        }


        //Borrar
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            Response<object> oResponse = new Response<object>();

            try
            {
                using (Contexto db = new Contexto())
                {
                    Inventory oInventory = db.InventoryDB.Find(Id);
                    //oInventory.Name = model.Name;
                    //oInventory.Stock = model.Stock;
                    //oInventory.Estado = model.Estado;
                    //oInventory.FechaCaducidad = model.FechaCaducidad;
                    //oInventory.Fecha = model.Fecha;
                    //oInventory.BasePrice = model.BasePrice;
                    //oInventory.Description = model.Description;
                    //oInventory.ProvedorId = model.ProvedorId;
                    //db.Entry(oInventory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    //db.InventoryDB.Update(oInventory);
                    db.Remove(oInventory);
                    db.SaveChanges();
                    oResponse.Exito = 1;
                }

            }
            catch (Exception ex)
            {
                oResponse.Mensaje = ex.Message;
            }
            return Ok(oResponse);

        }









    }

}
