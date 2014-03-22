using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibUsbDotNet;
using LibUsbDotNet.Info;
using LibUsbDotNet.Main;
using LibUsbDotNet.DeviceNotify;
using System.Collections.ObjectModel;

namespace USBDetect
{
    public partial class Form1 : Form
    {
        public static UsbDevice MyUsbDevice;
        public static IDeviceNotifier UsbDeviceNotifier = DeviceNotifier.OpenDeviceNotifier();
        
        public Form1()
        {
            // Hook the device notifier event
            UsbDeviceNotifier.OnDeviceNotify += OnDeviceNotifyEvent;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Disable the device notifier
            UsbDeviceNotifier.Enabled = false;
            // Unhook the device notifier event
            UsbDeviceNotifier.OnDeviceNotify -= OnDeviceNotifyEvent;
        }

        private void OnDeviceNotifyEvent(object sender, DeviceNotifyEventArgs e)
        {
            // Dump the event info to output.
            textBox1.Invoke(new EventHandler(delegate { textBox1.AppendText("\n#############\n"); }));
            textBox1.Invoke(new EventHandler(delegate { textBox1.AppendText(e.ToString()); }));
            label1.Text = e.Device.SerialNumber + " " + e.EventType.ToString();
            label2.Text = e.Device.IdProduct.ToString() + e.Device.IdVendor.ToString();
            textBox1.Invoke(new EventHandler(delegate { textBox1.AppendText("\n#############\n"); }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            // Dump all devices and descriptor information to + output.
            UsbRegDeviceList allDevices = UsbDevice.AllDevices;
            foreach (UsbRegistry usbRegistry in allDevices)
            {
                if (usbRegistry.Open(out MyUsbDevice))
                {
                    textBox2.AppendText(MyUsbDevice.Info.ToString());
                    for (int iConfig = 0; iConfig < MyUsbDevice.Configs.Count; iConfig++)
                    {
                        UsbConfigInfo configInfo = MyUsbDevice.Configs[iConfig];
                        textBox2.AppendText(configInfo.ToString());

                        ReadOnlyCollection<UsbInterfaceInfo> interfaceList = configInfo.InterfaceInfoList;
                        for (int iInterface = 0; iInterface < interfaceList.Count; iInterface++)
                        {
                            UsbInterfaceInfo interfaceInfo = interfaceList[iInterface];
                            textBox2.AppendText(interfaceInfo.ToString());

                            ReadOnlyCollection<UsbEndpointInfo> endpointList = interfaceInfo.EndpointInfoList;
                            for (int iEndpoint = 0; iEndpoint < endpointList.Count; iEndpoint++)
                            {
                                textBox2.AppendText(endpointList[iEndpoint].ToString());
                            }
                        }
                    }
                }
                textBox2.AppendText("\n===========\n");

            }

            // Free usb resources.
            // This is necessary for libusb-1.0 and Linux compatibility.
            UsbDevice.Exit();
        }
    }

}
