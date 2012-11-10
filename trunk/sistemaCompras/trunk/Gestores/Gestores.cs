using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Beans;

namespace Gestores
{
    public class GestorUsuario
    {
        private int sigId;
        private List<Usuario> lusuario;
        static GestorUsuario gestorUsuario = null;
        private GestorUsuario()
        {
            lusuario = new List<Usuario>();
            sigId = 1;
        }
        static public GestorUsuario Instancia()
        {
            if (gestorUsuario == null)
                gestorUsuario = new GestorUsuario();
            return gestorUsuario;
        }
        public void agregarUsuario(Usuario u)
        {
            u.setId(sigId++);
            u.setEliminado(false);
            u.setFechaIngreso(System.DateTime.Now);
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
        public void eliminarUsuario(Usuario u)
        {
            u.setEliminado(true);
        }
        public List<Usuario> seleccionarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            for (int i = 0; i < lusuario.Count; i++)
                if (!lusuario[i].getEliminado())
                    lista.Add(lusuario[i]);
            return lista;
        }
    }
    public class GestorTipoUsuario
    {
        private List<TipoUsuario> ltipousuario;
        static private GestorTipoUsuario gestorTipoUsuario = null;
        private GestorTipoUsuario()
        {
            ltipousuario = new List<TipoUsuario>();
            TipoUsuario tu = new TipoUsuario();
            tu.setId(1);
            tu.setDescripcion("Administrador");
            ltipousuario.Add(tu);
            tu = new TipoUsuario();
            tu.setId(2);
            tu.setDescripcion("Jefe de Proyecto");
            ltipousuario.Add(tu);
            tu = new TipoUsuario();
            tu.setId(3);
            tu.setDescripcion("Responsable de Compras");
            ltipousuario.Add(tu);
            tu = new TipoUsuario();
            tu.setId(4);
            tu.setDescripcion("Gerente de Logística");
            ltipousuario.Add(tu);
        }
        static public GestorTipoUsuario Instancia()
        {
            if (gestorTipoUsuario == null)
                gestorTipoUsuario = new GestorTipoUsuario();
            return gestorTipoUsuario;
        }
        public List<TipoUsuario> getListaTipoUsuarios()
        {
            return ltipousuario;
        }
    }
    public class GestorProyecto
    {
        private List<GestorProyecto> lproyecto;
        static GestorProyecto gestorProyecto = null;
        private GestorProyecto()
        {
            lproyecto = new List<GestorProyecto>();
        }
        static public GestorProyecto Instancia()
        {
            if (gestorProyecto == null)
                gestorProyecto = new GestorProyecto();
            return gestorProyecto;
        }
    }
    public class GestorProducto
    {
        private List<GestorProducto> lproducto;
        static GestorProducto gestorProducto = null;
        private GestorProducto()
        {
            lproducto = new List<GestorProducto>();
        }
        static public GestorProducto Instancia()
        {
            if (gestorProducto == null)
                gestorProducto = new GestorProducto();
            return gestorProducto;
        }
    }
    public class GestorUnidad
    {
        private List<GestorUnidad> lunidad;
        static GestorUnidad gestorUnidad = null;
        private GestorUnidad()
        {
            lunidad = new List<GestorUnidad>();
        }
        static public GestorUnidad Instancia()
        {
            if (gestorUnidad == null)
                gestorUnidad = new GestorUnidad();
            return gestorUnidad;
        }
    }
    public class GestorProveedor
    {
        private List<GestorProveedor> lproveedor;
        static GestorProveedor gestorProveedor = null;
        private GestorProveedor()
        {
            lproveedor = new List<GestorProveedor>();
        }
        static public GestorProveedor Instancia()
        {
            if (gestorProveedor == null)
                gestorProveedor = new GestorProveedor();
            return gestorProveedor;
        }
    }
}
