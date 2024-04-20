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
            Console.WriteLine("Número de serie del Disco Duro:");
            GetHardDriveSerialNumber();
            Console.WriteLine("\nUnidades de disco:");
            GetDriveInfo();
            Console.WriteLine("\nInventario general del sistema:");
            GetSystemInventory();
            Console.WriteLine("\nDirecciones MAC de las NIC:");
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
            int count = System.IO.DriveInfo.GetDrives().Count(drive => drive.IsReady);
            foreach (var drive in System.IO.DriveInfo.GetDrives())
            {
                Console.WriteLine($"Drive {drive.Name}");
                Console.WriteLine($"  Drive type: {drive.DriveType}");
                if (drive.IsReady == true)
                {
                    Console.WriteLine($"  Volume label: {drive.VolumeLabel}");
                    Console.WriteLine($"  File system: {drive.DriveFormat}");
                    Console.WriteLine($"  Available space to current user:{drive.AvailableFreeSpace} bytes");
                    Console.WriteLine($"  Total available space: {drive.TotalFreeSpace} bytes");
                    Console.WriteLine($"  Total size of drive: {drive.TotalSize} bytes");
                }
            }
            Console.WriteLine($"\nHay {count} cantidad de discos");
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

