using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Beans;
using System.IO;
using System.Data.OleDb;

namespace Gestores
{
    public class GestorUsuario
    {
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alulab11\Downloads\ComprasDB.accdb
        //string connectionString = @"PROVIDER=Microsoft.Jet.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\..\\..\\..\\Gestores\\DB\\ComprasDB.accdb";
        string connectionString = @"PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Guti\Documents\Visual Studio 2010\Projects\sistemaCompras\Gestores\DB\ComprasDB.accdb";

        private List<Usuario> lusuario;
        static GestorUsuario gestorUsuario = null;
        private GestorUsuario()
        {
            lusuario = new List<Usuario>();

        }
        static public GestorUsuario Instancia()
        {
            if (gestorUsuario == null)
                gestorUsuario = new GestorUsuario();
            return gestorUsuario;
        }
        public bool agregarUsuario(Usuario u)
        {
            bool resultado = true;

            u.setEliminado(false);
            u.setFechaIngreso(System.DateTime.Now);
            Console.WriteLine(u.getFechaNacimiento());
            Console.WriteLine(u.getFechaIngreso());
            //lusuario.Add(u);

            OleDbConnection conn = new OleDbConnection(connectionString);
            //OleDbCommand comando = new OleDbCommand("insert into Usuario(dni,nombre,fechaNacimiento,email,telefono,sueldo,fechaIngreso,nombreUsuario,contrasena,eliminado,tipoUsuario) "+
            //                                            "values(@dni,@nombre,@fechaNacimiento,@email,@telefono,@sueldo,@fechaIngreso,@nombreUsuario,@contrasena,@eliminado,@tipoUsuario)");

            OleDbCommand comando = new OleDbCommand("insert into Usuario(dni,nombre,fechaNacimiento,email,telefono,sueldo,nombreUsuario,contrasena,eliminado,tipoUsuario) "+
                                                        "values(@dni,@nombre,@fechaNacimiento,@email,@telefono,@sueldo,@nombreUsuario,@contrasena,@eliminado,@tipoUsuario)");

            
            //OleDbParameter paramDni0
            //comando.Parameters.Add(new OleDbParameter("@dni",u.getDni()));
            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@dni",u.getDni()),
                new OleDbParameter("@nombre",u.getNombre()),
                new OleDbParameter("@fechaNacimiento",u.getFechaNacimiento()),
                new OleDbParameter("@email",u.getEmail()),
                new OleDbParameter("@telefono",u.getTelefono()),
                new OleDbParameter("@sueldo",u.getSueldo()),
                //new OleDbParameter("@fechaIngreso",u.getFechaIngreso()),
                new OleDbParameter("@nombreUsuario",u.getNombreUsuario()),
                new OleDbParameter("@contrasena",u.getContrasena()),
                new OleDbParameter("@eliminado",u.getEliminado()),
                new OleDbParameter("@tipoUsuario",u.getTipoUsuario().getId()),
            });
            comando.Connection = conn;
            int res=0;
            try
            {
                Console.WriteLine(connectionString);
                conn.Open();
                Console.WriteLine("Conexion hecha");
                res = comando.ExecuteNonQuery();
                Console.WriteLine("Usuario Insertado: "+res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error!");
            }
            int x = System.Console.Read();
            resultado = res == 1;
            return resultado;
        }
        public bool modificarUsuario(Usuario u)
        {
            bool resultado = true;
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

            return resultado;
        }
        public bool eliminarUsuario(Usuario u)
        {
            bool resultado = true;
            u.setEliminado(true);
            return resultado;
        }
        public List<Usuario> seleccionarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            //for (int i = 0; i < lusuario.Count; i++)
            //    if (!lusuario[i].getEliminado())
            //        lista.Add(lusuario[i]);
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand comando = new OleDbCommand("select * from Usuario, TipoUsuario WHERE Usuario.tipoUsuario=TipoUsuario.ID");
            comando.Connection = conn;
            OleDbDataReader r=null;
            try
            {
                Console.WriteLine(connectionString);
                conn.Open();
                Console.WriteLine("Conexion hecha");
                r = comando.ExecuteReader();
                Console.WriteLine("Seleccionar Usuario: ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error!");
            }
            while (r.Read())
            {
                Usuario u = new Usuario();
                u.setId(r.GetInt32(0));
                u.setDni(r.GetInt32(1));
                u.setNombre(r.GetString(2));
                u.setFechaNacimiento(r.GetDateTime(3));
                u.setEmail(r.GetString(4));
                u.setTelefono(r.GetInt32(5));
                u.setSueldo(r.GetDouble(6));
                u.setFechaIngreso(r.GetDateTime(7));
                u.setNombreUsuario(r.GetString(8));
                u.setContrasena(r.GetString(9));
                u.setEliminado(r.GetBoolean(10));

                TipoUsuario tu = new TipoUsuario();
                tu.setId(r.GetInt32(11));
                tu.setDescripcion(r.GetString(13));

                u.setTipoUsuario(tu);

                lista.Add(u);
            }

            return lista;
        }

        public void filtrarUsuario(string nombre, Usuario usuario,bool incEliminado)
        {
            throw new NotImplementedException();
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

        public Producto getProductoById(int id)
        {
            int i;
            for (i = 0; i < this.lproducto.Count(); i++)
            {
                if (this.lproducto[i].getId() == id)
                {
                    return this.lproducto[i];
                }
            }
            return null;
        }

        public List<Producto> getProductosLikeNombre(String nombre)
        {
            List<Producto> lp = new List<Producto>();
            if (!nombre.Equals(""))
            {
                
                int i = 0;
                for (i = 0; i < this.lproducto.Count(); i++)
                {
                    if (this.lproducto[i].getNombre().Contains(nombre))
                    {
                        lp.Add(this.lproducto[i]);
                    }

                }
            }
            else
            {
                lp = this.lproducto;
            }

            return lp;
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
        private int sigId;
        static GestorProveedor gestorProveedor = null;
        private GestorProveedor()
        {            
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
            //lproveedor.Add(proveedor);                                             
        }

        public void modificarProveedor()
        {

        }

        public List<Proveedor> seleccionarProveedores()
        {
            return null;
        }
    }
}
