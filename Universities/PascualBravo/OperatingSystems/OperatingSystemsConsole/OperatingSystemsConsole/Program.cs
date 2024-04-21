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

namespace OperatingSystemsConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Número de serie del Disco Duro:");
            GetHardDriveSerialNumber();
            Console.WriteLine("\n2) Unidades de disco:");
            GetDriveInfo();
            Console.WriteLine("\n3) Inventario general del sistema:");
            GetSystemInventory();
            Console.WriteLine("\n4) Direcciones MAC de las NIC:");
            GetMacAddresses();
        }

        static void GetHardDriveSerialNumber()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                Console.WriteLine(wmi_HD["SerialNumber"]?.ToString().Trim());
            }
        }

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

            // To get patches, you would typically query the Win32_QuickFixEngineering class
            // However, it's worth noting this can be very slow and may require administrative privileges.
            // Uncomment the following lines if you want to include this in your inventory.

            /*
            mos = new ManagementObjectSearcher("SELECT * FROM Win32_QuickFixEngineering");
            foreach (ManagementObject mo in mos.Get())
            {
                Console.WriteLine($"Patch: {mo["Description"]} - {mo["HotFixID"]}");
            }
            */
        }

        static void GetMacAddresses()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE MACAddress IS NOT NULL");
            foreach (ManagementObject mo in mos.Get())
            {
                Console.WriteLine($"MAC Address: {mo["MACAddress"]}");
            }
        }
    }
}

