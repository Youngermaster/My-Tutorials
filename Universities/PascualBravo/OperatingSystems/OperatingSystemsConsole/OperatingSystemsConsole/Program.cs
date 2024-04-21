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
            ListarProcesosActivos();  // Debería ser GetHardDriveSerialNumber()

            // Listar e imprimir información sobre las unidades de disco
            Console.WriteLine("\n2) Unidades de disco:");
            GetDriveInfo();

            // Obtener e imprimir el inventario general del sistema
            Console.WriteLine("\n3) Inventario general del sistema:");
            GetSystemInventory();

            // Obtener e imprimir las direcciones MAC de las tarjetas de red
            Console.WriteLine("\n4) Direcciones MAC de las NIC:");
            GetMacAddresses();

            // Acceso al registro de Windows y operaciones sobre claves
            Console.WriteLine("\n5) Acceso al Registro del Sistema:");
            var subKeyName = @"Software\MiSoftware";
            var valueName = "Configuracion";

            // Crear una clave en el registro y establecer un valor
            CreateSubKey(subKeyName, valueName, "ValorInicial");

            // Leer y mostrar el valor de una clave del registro
            string valor = ReadSubKeyValue(subKeyName, valueName);
            Console.WriteLine($"Valor leído: {valor}");

            // Modificar y mostrar el valor de una clave del registro
            ModifySubKeyValue(subKeyName, valueName, "NuevoValor");
            valor = ReadSubKeyValue(subKeyName, valueName);
            Console.WriteLine($"Valor modificado: {valor}");

            // Borrar una clave del registro y verificar su eliminación
            DeleteSubKey(subKeyName, valueName);
            valor = ReadSubKeyValue(subKeyName, valueName);
            Console.WriteLine($"Valor después de borrar: {(valor == null ? "No existe" : valor)}");

            // Listar los procesos activos en el sistema
            Console.WriteLine("\n6) Procesos activos y cerrar un proceso:");
            ListarProcesosActivos();
            
            // Intentar cerrar el proceso 'notepad.exe' si está en ejecución
            TerminarProceso("notepad");
        }

        // Método para obtener y listar el número de serie de los discos duros
        static void ListarProcesosActivos()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                Console.WriteLine(wmi_HD["SerialNumber"]?.ToString().Trim());
            }
        }

        // Método para obtener y mostrar información de las unidades de disco
        static void GetDriveInfo()
        {
            int cantidadDiscos = System.IO.DriveInfo.GetDrives().Count(drive => drive.IsReady);
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
        static void GetSystemInventory()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject managementObject in mos.Get())
            {
                Console.WriteLine($"Procesador(es): {managementObject["NumberOfProcessors"]}");
                Console.WriteLine($"RAM: {managementObject["TotalPhysicalMemory"]}");
            }

            mos = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True");
            foreach (ManagementObject mo in mos.Get())
            {
                Console.WriteLine($"NIC: {mo["Description"]}");
            }
        }

        // Método para obtener y mostrar las direcciones MAC de las tarjetas de red
        static void GetMacAddresses()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE MACAddress IS NOT NULL");
            foreach (ManagementObject mo in mos.Get())
            {
                Console.WriteLine($"MAC Address: {mo["MACAddress"]}");
            }
        }

        // Métodos para trabajar con el registro de Windows: crear, leer, modificar y borrar claves
        static void CreateSubKey(string subKeyName, string valueName, object value)
        {
            // Crea o abre la subclave especificada
            using (var key = Registry.CurrentUser.CreateSubKey(subKeyName))
            {
                key.SetValue(valueName, value);
                Console.WriteLine($"Clave '{valueName}' creada con el valor '{value}'.");
            }
        }

        static string ReadSubKeyValue(string subKeyName, string valueName)
        {
            // Abre la subclave especificada y lee el valor
            using (var key = Registry.CurrentUser.OpenSubKey(subKeyName))
            {
                if (key != null)
                {
                    object value = key.GetValue(valueName);
                    return value?.ToString();
                }
                else
                {
                    return null;
                }
            }
        }

        static void ModifySubKeyValue(string subKeyName, string valueName, object newValue)
        {
            // Abre la subclave especificada para escritura y modifica el valor
            using (var key = Registry.CurrentUser.OpenSubKey(subKeyName, writable: true))
            {
                if (key != null)
                {
                    key.SetValue(valueName, newValue);
                    Console.WriteLine($"Clave '{valueName}' modificada con el nuevo valor '{newValue}'.");
                }
                else
                {
                    Console.WriteLine($"No se encontró la clave '{subKeyName}'.");
                }
            }
        }

        static void DeleteSubKey(string subKeyName, string valueName)
        {
            // Abre la subclave especificada para escritura y elimina el valor
            using (var key = Registry.CurrentUser.OpenSubKey(subKeyName, writable: true))
            {
                if (key != null)
                {
                    key.DeleteValue(valueName);
                    Console.WriteLine($"Clave '{valueName}' eliminada.");
                }
                else
                {
                    Console.WriteLine($"No se encontró la clave '{subKeyName}' para eliminar.");
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
