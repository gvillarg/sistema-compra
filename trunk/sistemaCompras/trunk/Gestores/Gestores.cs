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
            if (gestorUsuario == null;
                gestorUsuario = new GestorUsuario();
            return gestorUsuario;
        }
        public void agregarUsuario(Usuario u)
        {
            lusuario.Add(u);
        }
        public void modificarUsuario(Usuario u)
        {
            int i;
            for (i = 0; u.getId() == lusuario[i].getId(); i++) ;
            Usuario u_temp = lusuario[i];
            u_temp.setId(u.getId());
            u_temp.setDni(u.getDni());
            u_temp.setDireccion(u.getDireccion());
            u_temp.setNombre(u.getNombre());
            u_temp.setFechaNacimiento(u.getFechaNacimiento());
            u_temp.setEmail(u.getEmail());
            u_temp.setTelefono(u.getTelefono());
            u_temp.setSueldo(u.getSueldo());
            u_temp.setFechaIngreso(u.getFechaIngreso());
            u_temp.setNombreUsuario(u.getNombreUsuario());
            u_temp.setContrasena(u.getContrasena());
            u_temp.setEliminado(u.getEliminado());
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
        private GestorUnidad()
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
