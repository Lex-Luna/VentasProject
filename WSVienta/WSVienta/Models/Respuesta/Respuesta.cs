namespace WSVienta.Models.Respuesta
{
    public class Respuesta
    {
        public Respuesta()
        {
            //this.Mensaje = "No se puede conectar";
            this.Exito = 0;
        }
        public int  Exito { get; set; }
        public string Mensaje { get; set; }
        public object Data { get; set; }
    }
}
