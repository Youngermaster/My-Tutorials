using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.Win32;
using System.Diagnostics;

// Espacio de nombres para la consola de operaciones del sistema
namespace OperatingSystemsConsole
{
    public class Program
    {
        // Método principal que se ejecuta al iniciar el programa
        static void Main(string[] args)
        {
            // Obtener e imprimir el número de serie del disco duro
            Console.WriteLine("1) Número de serie del Disco Duro:");
            ObtenerNumeroDeSerieDelDiscoDuro();

            // Listar e imprimir información sobre las unidades de disco
            Console.WriteLine("\n2) Unidades de disco:");
            ObtenerInformacionDeUnidades();

            // Obtener e imprimir el inventario general del sistema
            Console.WriteLine("\n3) Inventario general del sistema:");
            ObtenerInventarioDelSistema();

            // Obtener e imprimir las direcciones MAC de las tarjetas de red
            Console.WriteLine("\n4) Direcciones MAC de las NIC:");
            ObtenerDireccionesMAC();

            // Acceso al registro de Windows y operaciones sobre claves
            Console.WriteLine("\n5) Acceso al Registro del Sistema:");
            var nombreSubClave = @"Software\MiSoftware";
            var nombreValor = "Configuracion";

            // Crear una clave en el registro y establecer un valor
            CrearSubClave(nombreSubClave, nombreValor, "ValorInicial");
            // Leer y mostrar el valor de una clave del registro
            var valor = LeerValorSubClave(nombreSubClave, nombreValor);
            Console.WriteLine($"Valor leído: {valor}");

            // Modificar y mostrar el valor de una clave del registro
            ModificarValorSubClave(nombreSubClave, nombreValor, "NuevoValor");
            valor = LeerValorSubClave(nombreSubClave, nombreValor);
            Console.WriteLine($"Valor modificado: {valor}");

            // Borrar una clave del registro y verificar su eliminación
            EliminarSubClave(nombreSubClave, nombreValor);
            valor = LeerValorSubClave(nombreSubClave, nombreValor);
            Console.WriteLine($"Valor después de borrar: {(valor == null ? "No existe" : valor)}");

            // Listar los procesos activos en el sistema
            Console.WriteLine("\n6) Procesos activos y cerrar un proceso:");
            ListarProcesosActivos();
            
            // Intenta cerrar el proceso 'notepad.exe' si está en ejecución
            TerminarProceso("notepad");
        }

        // Método para obtener y listar el número de serie de los discos duros
        static void ObtenerNumeroDeSerieDelDiscoDuro()
        {
            ManagementObjectSearcher buscador = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            foreach (ManagementObject disco in buscador.Get())
            {
                Console.WriteLine(disco["SerialNumber"]?.ToString().Trim());
            }
        }

        // Método para obtener y mostrar información de las unidades de disco
        static void ObtenerInformacionDeUnidades()
        {
            int cantidadDiscos = System.IO.DriveInfo.GetDrives().Count(unidad => unidad.IsReady);
            Console.WriteLine($"\nLa cantidad de discos es: {cantidadDiscos}");
            foreach (var unidad in System.IO.DriveInfo.GetDrives())
            {
                Console.WriteLine($"Unidad {unidad.Name}");
                Console.WriteLine($"\tTipo de unidad: {unidad.DriveType}");
                if (unidad.IsReady == true)
                {
                    Console.WriteLine($"\tEtiqueta del volumen: {unidad.VolumeLabel}");
                    Console.WriteLine($"\tSistema de archivos: {unidad.DriveFormat}");
                    Console.WriteLine($"\tEspacio disponible para el usuario actual: {unidad.AvailableFreeSpace} bytes");
                    Console.WriteLine($"\tEspacio total disponible: {unidad.TotalFreeSpace} bytes");
                    Console.WriteLine($"\tTamaño total de la unidad: {unidad.TotalSize} bytes");
                }
            }
        }

        // Método para obtener y mostrar un inventario del sistema, incluyendo procesadores y memoria RAM
        static void ObtenerInventarioDelSistema()
        {
            ManagementObjectSearcher buscador = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject objeto in buscador.Get())
            {
                Console.WriteLine($"Procesador(es): {objeto["NumberOfProcessors"]}");
                Console.WriteLine($"RAM: {objeto["TotalPhysicalMemory"]}");
            }

            buscador = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True");
            foreach (ManagementObject adaptador in buscador.Get())
            {
                Console.WriteLine($"NIC: {adaptador["Description"]}");
            }
        }

        // Método para obtener y mostrar las direcciones MAC de las tarjetas de red
        static void ObtenerDireccionesMAC()
        {
            ManagementObjectSearcher buscador = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE MACAddress IS NOT NULL");
            foreach (ManagementObject adaptador in buscador.Get())
            {
                Console.WriteLine($"Dirección MAC: {adaptador["MACAddress"]}");
            }
        }

        // Métodos para trabajar con el registro de Windows: crear, leer, modificar y borrar claves
        static void CrearSubClave(string nombreSubClave, string nombreValor, object valor)
        {
            // Crea o abre la subclave especificada
            using (var clave = Registry.CurrentUser.CreateSubKey(nombreSubClave))
            {
                clave.SetValue(nombreValor, valor);
                Console.WriteLine($"Clave '{nombreValor}' creada con el valor '{valor}'.");
            }
        }

        static string LeerValorSubClave(string nombreSubClave, string nombreValor)
        {
            // Abre la subclave especificada y lee el valor
            using (var clave = Registry.CurrentUser.OpenSubKey(nombreSubClave))
            {
                if (clave != null)
                {
                    object valor = clave.GetValue(nombreValor);
                    return valor?.ToString();
                }
                else
                {
                    return null;
                }
            }
        }

        static void ModificarValorSubClave(string nombreSubClave, string nombreValor, object nuevoValor)
        {
            // Abre la subclave especificada para escritura y modifica el valor
            using (var clave = Registry.CurrentUser.OpenSubKey(nombreSubClave, writable: true))
            {
                if (clave != null)
                {
                    clave.SetValue(nombreValor, nuevoValor);
                    Console.WriteLine($"Clave '{nombreValor}' modificada con el nuevo valor '{nuevoValor}'.");
                }
                else
                {
                    Console.WriteLine($"No se encontró la clave '{nombreSubClave}'.");
                }
            }
        }

        static void EliminarSubClave(string nombreSubClave, string nombreValor)
        {
            // Abre la subclave especificada para escritura y elimina el valor
            using (var clave = Registry.CurrentUser.OpenSubKey(nombreSubClave, writable: true))
            {
                if (clave != null)
                {
                    clave.DeleteValue(nombreValor);
                    Console.WriteLine($"Clave '{nombreValor}' eliminada.");
                }
                else
                {
                    Console.WriteLine($"No se encontró la clave '{nombreSubClave}' para eliminar.");
                }
            }
        }

        // Métodos para listar y terminar procesos en ejecución
        static void ListarProcesosActivos()
        {
            // Obtiene y muestra una lista de todos los procesos en ejecución
            Process[] coleccionDeProcesos = Process.GetProcesses();
            foreach (Process proceso in coleccionDeProcesos)
            {
                Console.WriteLine($"PID: {proceso.Id}, Nombre: {proceso.ProcessName}");
            }
        }

        static void TerminarProceso(string nombreProceso)
        {
            // Encuentra y termina los procesos que coincidan con el nombre proporcionado
            Process[] procesos = Process.GetProcessesByName(nombreProceso);
            if (procesos.Length == 0)
            {
                Console.WriteLine($"No hay procesos con el nombre '{nombreProceso}' en ejecución.");
                return;
            }

            foreach (Process proceso in procesos)
            {
                Console.WriteLine($"Terminando el proceso: PID: {proceso.Id}, Nombre: {proceso.ProcessName}");
                proceso.Kill();
                proceso.WaitForExit(); // Espera hasta que el proceso se haya cerrado
                Console.WriteLine("Proceso terminado correctamente.");
            }
        }
    }
}
