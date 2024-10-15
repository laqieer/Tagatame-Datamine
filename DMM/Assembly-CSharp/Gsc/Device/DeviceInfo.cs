// Decompiled with JetBrains decompiler
// Type: Gsc.Device.DeviceInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Device
{
  [Token(Token = "0x20035DD")]
  public static class DeviceInfo
  {
    [Token(Token = "0x400FE0E")]
    public const string OSNAME = "windows";
    [Token(Token = "0x400FE0F")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string deviceModel;
    [Token(Token = "0x400FE10")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string deviceVendor;

    [Token(Token = "0x1700225A")]
    public static string DeviceModel
    {
      [Token(Token = "0x600EFFE"), Address(RVA = "0xB04DF0", Offset = "0xB03BF0", VA = "0x10B04DF0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700225B")]
    public static string DeviceVendor
    {
      [Token(Token = "0x600EFFF"), Address(RVA = "0xB04E30", Offset = "0xB03C30", VA = "0x10B04E30")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700225C")]
    public static string OperatingSystem
    {
      [Token(Token = "0x600F000"), Address(RVA = "0xB04E70", Offset = "0xB03C70", VA = "0x10B04E70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700225D")]
    public static string ProcessorType
    {
      [Token(Token = "0x600F001"), Address(RVA = "0xB04E80", Offset = "0xB03C80", VA = "0x10B04E80")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700225E")]
    public static int SystemMemorySize
    {
      [Token(Token = "0x600F002"), Address(RVA = "0xB04E90", Offset = "0xB03C90", VA = "0x10B04E90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F003")]
    [Address(RVA = "0xB04BE0", Offset = "0xB039E0", VA = "0x10B04BE0")]
    static DeviceInfo()
    {
    }

    [Token(Token = "0x600F004")]
    [Address(RVA = "0xB04A30", Offset = "0xB03830", VA = "0x10B04A30")]
    public static void SetGraphicsInfo(Dictionary<string, object> data)
    {
    }
  }
}
