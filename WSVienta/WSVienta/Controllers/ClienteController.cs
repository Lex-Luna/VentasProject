using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSVienta.Models;
using WSVienta.Models.Respuesta;
using WSVienta.Models.Reuest;

namespace WSVienta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta ores = new Respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    var lst = db.Clientes.ToList();
                    ores.Exito = 1;
                    ores.Mensaje = "COnsultado exitoso exitante";
                    ores.Data=lst;

                    
                }
            }
            catch (Exception ex)
            {
                ores.Mensaje = ex.Message;
            }
            return Ok(ores);//Transforma a JSON las consultas

        }

        [HttpPost]
        public IActionResult Add(ClienteRequest clireq) {
            Respuesta ores = new Respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    //Estas lineas son indispensables para crear un nuevo
                    //cliente desde el recuest hasta la bdd
                    Cliente ocli = new Cliente();  
                    ocli.Nombre = clireq.Nombre;
                    db.Clientes.Add(ocli);
                    db.SaveChanges();
                    ores.Exito = 1;
                    ores.Mensaje = "Agregado exitoso exitante";

                }
            }
            catch (Exception ex)
            {
                ores.Mensaje = ex.Message;
            }
            

            return Ok(ores);
        }


        [HttpPut]
        public IActionResult Edit(ClienteRequest clireq)
        {
            Respuesta ores = new Respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    //Estas lineas son indispensables para crear un nuevo
                    //cliente desde el recuest hasta la bdd
                    Cliente ocli = db.Clientes.Find(clireq.Id);
                    ocli.Nombre = clireq.Nombre;
                    //Esto indica que el registro se a modificado
                    db.Entry(ocli).State= Microsoft.EntityFrameworkCore.EntityState.Modified;

                    //db.Clientes.Add(ocli); esta linea ya no va
                    db.SaveChanges();
                    ores.Exito = 1;
                    ores.Mensaje = "Editado exitoso exitante";

                }
            }
            catch (Exception ex)
            {
                ores.Mensaje = ex.Message;
            }


            return Ok(ores);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Respuesta ores = new Respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    //Estas lineas son indispensables para crear un nuevo
                    //cliente desde el recuest hasta la bdd
                    Cliente ocli = db.Clientes.Find(id);
                    db.Remove(ocli);
                    db.SaveChanges();
                    ores.Exito = 1;
                    ores.Mensaje = "Borrado exitoso exitante";

                }
            }
            catch (Exception ex)
            {
                ores.Mensaje = ex.Message;
            }


            return Ok(ores);
        }

    }
}

                