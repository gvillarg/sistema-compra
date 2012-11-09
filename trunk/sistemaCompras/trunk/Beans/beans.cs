using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beans
{
    class Usuario
    {
        private int id;
        private int dni;
        private string direccion;
        private string nombre;
        private DateTime fechaNacimiento;
        private string email;
        private int telefono;
        private float sueldo;
        private DateTime fechaIngreso;
        private bool eliminado;

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getDni()
        {
            return dni;
        }
        public void setDni(int dni)
        {
            this.dni = dni;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public DateTime getFechaNacimiento()
        {
            return fechaNacimiento;
        }
        public void setFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public int getTelefono()
        {
            return telefono;
        }
        public void setTelefono(int telefono)
        {
            this.telefono = telefono;
        }
        public float getSueldo()
        {
            return sueldo;
        }
        public void setSueldo(float sueldo)
        {
            this.sueldo = sueldo;
        }
        public DateTime getFechaIngreso()
        {
            return fechaIngreso;
        }
        public void setFechaIngreso(DateTime fechaIngreso)
        {
            this.fechaIngreso = fechaIngreso;
        }
        public bool getEliminado()
        {
            return eliminado;
        }
        public void setEliminado(bool eliminado)
        {
            this.eliminado = eliminado;
        }
    }

    class Proyecto
    {
        private int id;
        private string nombre;
        private string descripcion;
        private bool eliminado;

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public bool getEliminado()
        {
            return eliminado;
        }
        public void setEliminado(bool eliminado)
        {
            this.eliminado = eliminado;
        }    
    }

    class Producto
    {
        int id;
        string descripcion;
        string nombre;
        string fabricante;
        bool eliminado;

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getFabricante()
        {
            return fabricante;
        }
        public void setFabricante(string fabricante)
        {
            this.fabricante = fabricante;
        }
        public bool getEliminado()
        {
            return eliminado;
        }
        public void setEliminado(bool eliminado)
        {
            this.eliminado = eliminado;
        }
    }

    class Proveedor
    {
        int id;
        int ruc;
        string razonSocial;
        string direccion;
        string paginaWeb;
        string rubro;
        string nombreContacto;
        string emailContacto;
        int telefonoContacto;
        bool eliminado;

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getRuc()
        {
            return ruc;
        }
        public void setRuc(int ruc)
        {
            this.ruc = ruc;
        }
        public string getRazonSocial()
        {
            return razonSocial;
        }
        public void setRazonSocial(string razonSocial)
        {
            this.razonSocial = razonSocial;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public string getPaginaWeb()
        {
            return paginaWeb;
        }
        public void setPaginaWeb(string paginaWeb)
        {
            this.paginaWeb = paginaWeb;
        }
        public string getRubro()
        {
            return rubro;
        }
        public void setRubro(string rubro)
        {
            this.rubro = rubro;
        }
        public string getNombreContacto()
        {
            return nombreContacto;
        }
        public void setNombreContacto(string nombreContacto)
        {
            this.nombreContacto = nombreContacto;
        }
        public string getEmailContacto()
        {
            return emailContacto;
        }
        public void setEmailContacto(string emailContacto)
        {
            this.emailContacto = emailContacto;
        }
        public int getTelefonoContacto()
        {
            return telefonoContacto;
        }
        public void setTelefonoContacto(int telefonoContacto)
        {
            this.telefonoContacto = telefonoContacto;
        }
        public bool getEliminado()
        {
            return eliminado;
        }
        public void setEliminado(bool eliminado)
        {
            this.eliminado = eliminado;
        }		     
    }

    class TipoUsuario
    {
        int id;
        string descripcion;

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }    
    }

    class Unidad
    {
        int id;
        string descripcion;

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }    
    }

}
