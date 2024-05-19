﻿using Android.Hardware.Usb;

namespace UsbSerialAndroid.Driver;

public sealed class CdcAcmSerialDriverFactory : IUsbSerialDriverFactory
{
    public IUsbSerialDriver Create(UsbDevice device)
    {
        return new CdcAcmSerialDriver(device);
    }

    public Dictionary<int, int[]> GetSupportedDevices()
    {
        return [];
    }

    public bool Probe(UsbDevice device)
    {
        return device.CountAcmPorts() > 0;
    }
}
