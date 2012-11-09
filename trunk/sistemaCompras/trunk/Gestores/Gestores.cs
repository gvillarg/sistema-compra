using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Beans;

namespace Gestores
{
    public class GestorUsuario
    {
        static private List<Usuario> lusuario;
        GestorUsuario gestorUsuario = null;
        private GestorUsuario()
        {
            lusuario = new List<Usuario>();
        }
        public GestorUsuario Instancia()
        {
            if (gestorUsuario == null)
                gestorUsuario = new GestorUsuario();
            return gestorUsuario;
        }
    }
    public class GestorTipoUsuario
    {
        static private List<TipoUsuario> ltipousuario;
        GestorTipoUsuario gestorTipoUsuario = null;
        private GestorTipoUsuario()
        {
            ltipousuario = new List<TipoUsuario>();
        }
        public GestorTipoUsuario Instancia()
        {
            if (gestorTipoUsuario == null)
                gestorTipoUsuario = new GestorTipoUsuario();
            return gestorTipoUsuario;
        }
    }
    public class GestorProyecto
    {
        static private List<GestorProyecto> lproyecto;
        GestorProyecto gestorProyecto = null;
        private GestorProyecto()
        {
            lproyecto = new List<GestorProyecto>();
        }
        public GestorProyecto Instancia()
        {
            if (gestorProyecto == null)
                gestorProyecto = new GestorProyecto();
            return gestorProyecto;
        }
    }
    public class GestorProducto
    {
        static private List<GestorProducto> lproducto;
        GestorProducto gestorProducto = null;
        private GestorProducto()
        {
            lproducto = new List<GestorProducto>();
        }
        public GestorProducto Instancia()
        {
            if (gestorProducto == null)
                gestorProducto = new GestorProducto();
            return gestorProducto;
        }
    }
    public class GestorUnidad
    {
        static private List<GestorUnidad> lunidad;
        GestorUnidad gestorUnidad = null;
        private GestorProducto()
        {
            lunidad = new List<GestorUnidad>();
        }
        public GestorUnidad Instancia()
        {
            if (gestorUnidad == null)
                gestorUnidad = new GestorUnidad();
            return gestorUnidad;
        }
    }
    public class GestorProveedor
    {
        static private List<GestorProveedor> lproveedor;
        GestorProveedor gestorProveedor = null;
        private GestorProveedor()
        {
            lproveedor = new List<GestorProveedor>();
        }
        public GestorProveedor Instancia()
        {
            if (gestorProveedor == null)
                gestorProveedor = new GestorProveedor();
            return gestorProveedor;
        }
    }
}
