﻿using Microsoft.Win32;
using SophiApp.Helpers;
using System.Linq;
using System.ServiceProcess;

namespace SophiApp.Actions
{
    //TODO: Implement system state methods

    public class SystemStateAction
    {
        public static void _100(bool IsActive)
        {
            var diagTrack = ServiceHelper.GetService(ActionsData._100_DIAGTRACK_NAME);
            var firewallRule = FirewallHelper.GetGroupRule(ActionsData._100_DIAGTRACK_NAME).FirstOrDefault();

            if (IsActive)
            {
                ServiceHelper.ChangeStartMode(diagTrack, ServiceStartMode.Automatic);
                diagTrack.Start();
                // Allow connection for the Unified Telemetry Client Outbound Traffic
                firewallRule.Enabled = true;
                firewallRule.Action = NetFwTypeLib.NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                return;
            }

            diagTrack.Stop();
            ServiceHelper.ChangeStartMode(diagTrack, ServiceStartMode.Disabled);
            // Block connection for the Unified Telemetry Client Outbound Traffic
            firewallRule.Enabled = false;
            firewallRule.Action = NetFwTypeLib.NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
        }

        public static void _265(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.SetSubKey(hive: RegistryHive.ClassesRoot, path: ActionsData._265_EXTRACT_PATH).CreateSubKey(ActionsData._265_COMMAND_NAME).SetValue(string.Empty, ActionsData._265_EXTRACT_VALUE);
                RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._265_EXTRACT_PATH, name: ActionsData._265_MUIVERB_NAME, value: ActionsData._265_MUIVERB_VALUE);
                RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._265_EXTRACT_PATH, name: ActionsData._265_ICON_NAME, value: ActionsData._265_ICON_VALUE);
                return;
            }

            Registry.ClassesRoot.DeleteSubKeyTree(ActionsData._265_EXTRACT_PATH);
        }

        public static void _267(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._267_RUNASUSER_PATH, name: ActionsData._267_EXTENDED_NAME);

                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._267_RUNASUSER_PATH, name: ActionsData._267_EXTENDED_NAME, value: string.Empty);
        }

        public static void _268(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.LocalMachine, path: ActionsData._268_CAST_TO_DEVICE_PATH, name: ActionsData._268_CAST_TO_DEVICE_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.LocalMachine, path: ActionsData._268_CAST_TO_DEVICE_NAME,
                               name: ActionsData._268_CAST_TO_DEVICE_NAME, value: ActionsData._268_CAST_TO_DEVICE_VALUE);
        }

        public static void _269(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.LocalMachine, path: ActionsData._269_SHARE_CONTENT_PATH, name: ActionsData._269_SHARE_CONTENT_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.LocalMachine, path: ActionsData._269_SHARE_CONTENT_PATH,
                               name: ActionsData._269_SHARE_CONTENT_NAME, value: string.Empty);
        }

        public static void _271(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._271_3D_EDIT_BMP_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._271_3D_EDIT_BMP_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _272(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._272_3D_EDIT_GIF_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._272_3D_EDIT_GIF_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _273(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._273_3D_EDIT_JPE_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._273_3D_EDIT_JPE_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _274(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._274_3D_EDIT_JPEG_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._274_3D_EDIT_JPEG_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _275(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._275_3D_EDIT_JPG_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._275_3D_EDIT_JPG_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _276(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._276_3D_EDIT_PNG_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._276_3D_EDIT_PNG_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _277(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._277_3D_EDIT_TIF_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._277_3D_EDIT_TIF_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _278(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._278_3D_EDIT_TIFF_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._278_3D_EDIT_TIFF_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _279(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._279_SHELL_EDIT_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._279_SHELL_EDIT_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _280(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._280_SHELL_CREATE_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._280_SHELL_CREATE_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _281(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._281_SHELL_EDIT_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._281_SHELL_EDIT_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _282(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._282_BAT_PRINT_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                RegHelper.DeleteKey(hive: RegistryHive.ClassesRoot, path: ActionsData._282_CMD_PRINT_PATH, name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._282_BAT_PRINT_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._282_CMD_PRINT_PATH,
                               name: ActionsData.PROGRAMMATIC_ACCESS_ONLY_NAME, value: string.Empty);
        }

        public static void _283(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._283_LIBRARY_LOCATION_PATH,
                                   name: string.Empty, value: ActionsData._283_LIBRARY_LOCATION_VALUE);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._283_LIBRARY_LOCATION_PATH,
                               name: string.Empty, value: ActionsData._283_LIBRARY_LOCATION_MINUS_VALUE);
        }

        public static void _284(bool IsActive)
        {
            if (IsActive)
            {
                RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._284_SEND_TO_PATH,
                                   name: string.Empty, value: ActionsData._284_SEND_TO_VALUE);
                return;
            }

            RegHelper.SetValue(hive: RegistryHive.ClassesRoot, path: ActionsData._284_SEND_TO_PATH,
                                   name: string.Empty, value: ActionsData._284_SEND_TO_MINUS_VALUE);
        }

        public static void FOR_DEBUG_ONLY(bool state)
        {
        }
    }
}