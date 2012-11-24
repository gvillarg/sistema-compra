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
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\DB\ComprasDB.accdb
        //string connectionString = @"PROVIDER=Microsoft.Jet.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\..\\..\\..\\Gestores\\DB\\ComprasDB.accdb";
        private string connectionString = @"PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=./DB/ComprasDB.accdb";
       


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
            //u.setFechaIngreso(System.DateTime.Now);
            //Console.WriteLine(u.getFechaNacimiento());
            //Console.WriteLine(u.getFechaIngreso());
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
            finally { conn.Close(); }
            resultado = res == 1;
            return resultado;
        }
        public bool modificarUsuario(Usuario u)
        {
            bool resultado = true;

            //u.setFechaIngreso(System.DateTime.Now);
            //Console.WriteLine(u.getFechaNacimiento());
            //Console.WriteLine(u.getFechaIngreso());
            //lusuario.Add(u);

            OleDbConnection conn = new OleDbConnection(connectionString);
            //OleDbCommand comando = new OleDbCommand("insert into Usuario(dni,nombre,fechaNacimiento,email,telefono,sueldo,fechaIngreso,nombreUsuario,contrasena,eliminado,tipoUsuario) "+
            //                                            "values(@dni,@nombre,@fechaNacimiento,@email,@telefono,@sueldo,@fechaIngreso,@nombreUsuario,@contrasena,@eliminado,@tipoUsuario)");

            OleDbCommand comando = new OleDbCommand("UPDATE Usuario SET dni=@dni,nombre=@nombre,fechaNacimiento=@fechaNacimiento,email=@email,telefono=@telefono, "+
                                                    "sueldo=@sueldo,nombreUsuario=@nombreUsuario,contrasena=@contrasena,tipoUsuario=@tipoUsuario " +
                                                    "WHERE id=@id");


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
                //new OleDbParameter("@eliminado",u.getEliminado()),
                new OleDbParameter("@tipoUsuario",u.getTipoUsuario().getId()),
                new OleDbParameter("@id",u.getId())
            });
            comando.Connection = conn;
            try
            {
                conn.Open();
                Console.WriteLine("Conexion hecha");
                resultado = comando.ExecuteNonQuery() == 1;
                Console.WriteLine("Usuario Eliminado ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error!");
            }
            finally { conn.Close(); }
            return resultado;
        }
        public bool eliminarUsuario(Usuario u)
        {
            bool resultado = false;
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand comando = new OleDbCommand("UPDATE Usuario SET Usuario.eliminado = True WHERE ID=@id");
            comando.Parameters.Add(new OleDbParameter("@id",u.getId()));
            comando.Connection = conn;
            try
            {
                conn.Open();
                Console.WriteLine("Conexion hecha");
                resultado = comando.ExecuteNonQuery() == 1;
                Console.WriteLine("Usuario Eliminado ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error!");
            }
            finally { conn.Close(); }
            return resultado;
        }
        public List<Usuario> seleccionarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            //for (int i = 0; i < lusuario.Count; i++)
            //    if (!lusuario[i].getEliminado())
            //        lista.Add(lusuario[i]);
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand comando = new OleDbCommand("select * from Usuario, TipoUsuario WHERE Usuario.tipoUsuario=TipoUsuario.ID and Usuario.eliminado=false");
            comando.Connection = conn;
            OleDbDataReader r=null;
            try
            {
                Console.WriteLine(connectionString);
                conn.Open();
                Console.WriteLine("Conexion hecha");
                r = comando.ExecuteReader();
                Console.WriteLine("Seleccionar Usuario: ");
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error!");
            }
            finally { r.Close(); conn.Close(); }
            return lista;
        }

        public List<Usuario> filtrarUsuarios(string nombre, TipoUsuario tipoUsuario, bool incEliminado)
        {
            List<Usuario> lista = new List<Usuario>();
            //for (int i = 0; i < lusuario.Count; i++)
            //    if (!lusuario[i].getEliminado())
            //        lista.Add(lusuario[i]);
            OleDbConnection conn = new OleDbConnection(connectionString);
            String sqlString = "select * from Usuario, TipoUsuario "
                            + "WHERE (Usuario.tipoUsuario=TipoUsuario.ID) "
                            + "and (Usuario.eliminado=false or @incEliminado) "
                            + "and (Usuario.nombre like @nombre) ";
            if (tipoUsuario != null)
                sqlString = sqlString + "and (Usuario.tipoUsuario=@tipoUsuario)";


            OleDbCommand comando = new OleDbCommand(sqlString);
            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@incEliminado",incEliminado),
                new OleDbParameter("@nombre",nombre)
            });
            if (tipoUsuario != null)
                comando.Parameters.AddWithValue("@tipoUsuario", tipoUsuario.getId());

            comando.Connection = conn;
            OleDbDataReader r = null;
            try
            {
                Console.WriteLine(connectionString);
                conn.Open();
                Console.WriteLine("Conexion hecha");
                r = comando.ExecuteReader();
                Console.WriteLine("Seleccionar Usuario: ");
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error!");
            }
            finally { r.Close(); conn.Close(); }
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
            tu.setDescripcion("Gerente de Logística");
            ltipousuario.Add(tu);
            tu = new TipoUsuario();
            tu.setId(3);
            tu.setDescripcion("Jefe de Proyecto");
            ltipousuario.Add(tu);
            tu = new TipoUsuario();
            tu.setId(4);
            tu.setDescripcion("Responsable de Compras");
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
        private string connectionString = @"PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=./DB/ComprasDB.accdb";
        private GestorProducto()
        {
            //lproducto = new List<Producto>();
            lproducto = getLproducto();
        }

        public List<Producto> getLproducto()
        {
            //return this.lproducto;

            //this.lproducto.Add(prod);
            List<Producto> lista = new List<Producto>();
            //for (int i = 0; i < lusuario.Count; i++)
            //    if (!lusuario[i].getEliminado())
            //        lista.Add(lusuario[i]);
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand comando = new OleDbCommand("select id, nombre, descripcion, fabricante, eliminado from producto where eliminado=false");
            comando.Connection = conn;
            OleDbDataReader r = null;
            try
            {
                Console.WriteLine(connectionString);
                conn.Open();
                Console.WriteLine("Conexion hecha");
                r = comando.ExecuteReader();
                Console.WriteLine("Seleccionar Usuario: ");
                while (r.Read())
                {
                    Producto p = new Producto();
                    p.setId(r.GetInt32(0));
                    p.setNombre(r.GetString(1));
                    p.setDescripcion(r.GetString(2));
                    p.setFabricante(r.GetString(3));
                    p.setEliminado(r.GetBoolean(4));
                    lista.Add(p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error!");
            }
            finally { r.Close(); conn.Close(); }
            this.lproducto = lista;
            return lista;
        }

        static public GestorProducto Instancia()
        {
            if (gestorProducto == null)
                gestorProducto = new GestorProducto();
            return gestorProducto;
        }

        public void agregarProducto(Producto prod)
        {
            //this.lproducto.Add(prod);
            bool resultado = true;

           
            

            OleDbConnection conn = new OleDbConnection(this.connectionString);
            OleDbCommand comando = new OleDbCommand("insert into producto(descripcion,nombre,fabricante,eliminado) " +
                                                        "values(@descripcion,@nombre,@fabricante,@eliminado)");

            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@descripcion",prod.getDescripcion()),
                new OleDbParameter("@nombre",prod.getNombre()),
                new OleDbParameter("@fabricante",prod.getFabricante()),
                new OleDbParameter("@eliminado",prod.getEliminado()),
           
            });
            comando.Connection = conn;
            int res = 0;
            try
            {
                
                conn.Open();
                
                res = comando.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!");
            }
            finally { conn.Close(); }
            resultado = res == 1;
            //return resultado;
        }

        public void eliminarProducto(int id)
        {
            bool resultado = true;

            //u.setFechaIngreso(System.DateTime.Now);
            //Console.WriteLine(u.getFechaNacimiento());
            //Console.WriteLine(u.getFechaIngreso());
            //lusuario.Add(u);

            OleDbConnection conn = new OleDbConnection(connectionString);
            //OleDbCommand comando = new OleDbCommand("insert into Usuario(dni,nombre,fechaNacimiento,email,telefono,sueldo,fechaIngreso,nombreUsuario,contrasena,eliminado,tipoUsuario) "+
            //                                            "values(@dni,@nombre,@fechaNacimiento,@email,@telefono,@sueldo,@fechaIngreso,@nombreUsuario,@contrasena,@eliminado,@tipoUsuario)");

            OleDbCommand comando = new OleDbCommand("UPDATE producto SET eliminado=true where id=@id");


            //OleDbParameter paramDni0
            //comando.Parameters.Add(new OleDbParameter("@dni",u.getDni()));
            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@id",id),
               
            });
            comando.Connection = conn;
            try
            {
                conn.Open();
                Console.WriteLine("Conexion hecha");
                resultado = comando.ExecuteNonQuery() == 1;
                Console.WriteLine("Usuario Eliminado ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error!");
            }
            finally { conn.Close(); }
            this.lproducto = this.getLproducto();
            /*
            int i;
            for (i = 0; i < this.lproducto.Count; i++)
            {
                if (this.lproducto[i].getId() == id)
                {
                    this.lproducto[i].setEliminado(true);
                    break;
                }
            }*/
        }

        public void modificarProducto(Producto u)
        {
            bool resultado = true;

            //u.setFechaIngreso(System.DateTime.Now);
            //Console.WriteLine(u.getFechaNacimiento());
            //Console.WriteLine(u.getFechaIngreso());
            //lusuario.Add(u);

            OleDbConnection conn = new OleDbConnection(connectionString);
            //OleDbCommand comando = new OleDbCommand("insert into Usuario(dni,nombre,fechaNacimiento,email,telefono,sueldo,fechaIngreso,nombreUsuario,contrasena,eliminado,tipoUsuario) "+
            //                                            "values(@dni,@nombre,@fechaNacimiento,@email,@telefono,@sueldo,@fechaIngreso,@nombreUsuario,@contrasena,@eliminado,@tipoUsuario)");

            OleDbCommand comando = new OleDbCommand("UPDATE producto SET nombre=@nombre,fabricante=@fabricante,descripcion=@descripcion where id=@id");


            //OleDbParameter paramDni0
            //comando.Parameters.Add(new OleDbParameter("@dni",u.getDni()));
            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@nombre",u.getNombre()),
                new OleDbParameter("@fabricante",u.getFabricante()),
                new OleDbParameter("@descripcion",u.getDescripcion()),
                new OleDbParameter("@id",u.getId()),
            });
            comando.Connection = conn;
            try
            {
                conn.Open();
                Console.WriteLine("Conexion hecha");
                resultado = comando.ExecuteNonQuery() == 1;
                Console.WriteLine("Usuario Eliminado ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error!");
            }
            finally { conn.Close(); }

            this.lproducto = this.getLproducto();
            /*
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
            */

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
            lp = this.getLproducto();
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
                lp = this.getLproducto();
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
        string connectionString = @"PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jonatan\Documents\Visual Studio 2010\Projects\sistemaCompras(7)\Gestores\DB\ComprasDB.accdb";        
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

        public bool agregarProveedor(Proveedor proveedor)
        {
            bool resultado = true;                      
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand comando = new OleDbCommand("INSERT INTO Proveedor(ruc, razonSocial, direccion, paginaWeb, rubro, nombreContacto, emailContacto, telefonoContacto, eliminado) "+
                                                     "VALUES (@ruc, @razonSocial, @direccion, @paginaWeb, @rubro, @nombreContacto, @emailContacto, @telefonoContacto, @eliminado)");
            
            comando.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@ruc", proveedor.getRuc()),
                new OleDbParameter("@razonSocial", proveedor.getRazonSocial()),
                new OleDbParameter("@direccion", proveedor.getDireccion()),
                new OleDbParameter("@paginaWeb", proveedor.getPaginaWeb()),
                new OleDbParameter("@rubro", proveedor.getRubro()),
                new OleDbParameter("@nombreContacto", proveedor.getNombreContacto()),
                new OleDbParameter("@emailContacto", proveedor.getEmailContacto()),
                new OleDbParameter("@telefonoContacto", proveedor.getTelefonoContacto()),
                new OleDbParameter("@eliminado", proveedor.getEliminado()),
            });

            comando.Connection = conn;
            int res = 0;
            try
            {
                Console.WriteLine(connectionString);
                conn.Open();
                Console.WriteLine("Conexion hecha");
                res = comando.ExecuteNonQuery();
                Console.WriteLine("Proveedor Insertado: " + res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error!");
            }            
            resultado = res == 1;
            return resultado;                                
        }

        public void modificarProveedor(Proveedor proveedor)
        {

        }

        public void eliminarProveedor(Proveedor proveedor)
        {


        }

        public List<Proveedor> seleccionarProveedores()
        {
            return null;
        }
    }
}
