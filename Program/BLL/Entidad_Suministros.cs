using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Ingreso_suministros
    {
        private int _ID_Solicitud_Articulos;
        private int _ID_Articulo_Proveedor;
        private int _ID_Solicitud_Compra;
        private int _Cantidad;
        private String _Descripcion;
        

        public int ID_Articulo_Proveedor { get => _ID_Articulo_Proveedor; set => _ID_Articulo_Proveedor = value; }
        public int ID_Solicitud_Compra { get => _ID_Solicitud_Compra; set => _ID_Solicitud_Compra = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int ID_Solicitud_Articulos { get => _ID_Solicitud_Articulos; set => _ID_Solicitud_Articulos = value; }

        public Ingreso_suministros()
        {
        }

        public Ingreso_suministros(int ShipperID, string CompanyName, string Phone)
        {
            _ID_Solicitud_Articulos = ID_Solicitud_Articulos;
            _ID_Articulo_Proveedor = ID_Articulo_Proveedor;
            _ID_Solicitud_Compra = ID_Solicitud_Compra;
            _Cantidad = Cantidad;
            _Descripcion = Descripcion;
        }
    }
}
