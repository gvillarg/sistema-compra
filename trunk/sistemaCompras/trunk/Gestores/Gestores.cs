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
            for (i = 0; u.getId() != lusuario[i].getId(); i++) ;
            Usuario u_temp = lusuario[i];
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
            u_temp.setTipoUsuario(u.getTipoUsuario());
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
        public List<TipoUsuario> SeleccionarListaTipoUsuarios()
        {
            return ltipousuario;
        }
    }
    public class GestorProyecto
    {
        private List<Proyecto> lproyecto;
        static GestorProyecto gestorProyecto = null;
        private int id = 0;

        private GestorProyecto()
        {
            lproyecto = new List<Proyecto>();
        }

        public void agregarProyecto(Proyecto p)
        {
            p.setId(id++);
            p.setEliminado(false);
            lproyecto.Add(p);
        }

        public void modificarProyecto(Proyecto p)
        {
            int i;
            for (i = 0; p.getId() == lproyecto[i].getId(); i++) ;
            Proyecto paux = lproyecto[i];
            paux.setId(p.getId());
            paux.setNombre(p.getNombre());
            paux.setDescripcion(p.getDescripcion());
            paux.setEliminado(p.getEliminado());
        }

        public void eliminarProyecto(Proyecto p)
        {
            p.setEliminado(true);
        }

        public List<Proyecto> seleccionarProyectos()
        {
            List<Proyecto> proy = new List<Proyecto>();
            for (int i = 0; i < lproyecto.Count; i++)
                if (!lproyecto[i].getEliminado())
                    proy.Add(lproyecto[i]);
            return proy;
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
        private List<Producto> lproducto;
        static GestorProducto gestorProducto = null;
        private GestorProducto()
        {
            lproducto = new List<Producto>();
        }

        public List<Producto> getLproducto()
        {
            return this.lproducto;
        }

        static public GestorProducto Instancia()
        {
            if (gestorProducto == null)
                gestorProducto = new GestorProducto();
            return gestorProducto;
        }

        public void agregarProducto(Producto prod)
        {
            this.lproducto.Add(prod);
        }

        public void eliminarProducto(int id)
        {
            int i;
            for (i = 0; i < this.lproducto.Count; i++)
            {
                if (this.lproducto[i].getId() == id)
                {
                    this.lproducto[i].setEliminado(true);
                    break;
                }
            }
        }

        public void modificarProducto(Producto prod)
        {
            int i;
            for (i = 0; i < this.lproducto.Count; i++)
            {
                if (this.lproducto[i].getId() == prod.getId())
                {
                    this.lproducto[i].setNombre(prod.getNombre());
                    this.lproducto[i].setDescripcion(prod.getDescripcion());
                    this.lproducto[i].setFabricante(prod.getFabricante());
                    this.lproducto[i].setEliminado(prod.getEliminado());
                    break;
                }
            }
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
        private List<Proveedor> lproveedor;
        private int sigId;
        static GestorProveedor gestorProveedor = null;
        private GestorProveedor()
        {
            lproveedor = new List<Proveedor>();
            sigId = 1;
        }
        static public GestorProveedor Instancia()
        {
            if (gestorProveedor == null)
                gestorProveedor = new GestorProveedor();
            return gestorProveedor;
        }

        public void agregarProveedor(Proveedor proveedor)
        {
            proveedor.setId(sigId++);            
            lproveedor.Add(proveedor);                                             
        }
        public List<Proveedor> seleccionarProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();
            for (int i = 0; i < lproveedor.Count; i++)
                if (!lproveedor[i].getEliminado())
                    lista.Add(lproveedor[i]);
            return lista;
        }
    }
}
