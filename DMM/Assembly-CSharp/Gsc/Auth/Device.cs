// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.Device
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Auth
{
  [Token(Token = "0x2003655")]
  public static class Device
  {
    [Token(Token = "0x400FF50")]
    [FieldOffset(Offset = "0x0")]
    private static IDevice device;

    [Token(Token = "0x170022FF")]
    public static string Platform
    {
      [Token(Token = "0x600F2ED"), Address(RVA = "0xB21620", Offset = "0xB20420", VA = "0x10B21620")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002300")]
    public static bool initialized
    {
      [Token(Token = "0x600F2EE"), Address(RVA = "0xB216C0", Offset = "0xB204C0", VA = "0x10B216C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002301")]
    public static bool hasError
    {
      [Token(Token = "0x600F2EF"), Address(RVA = "0xB21670", Offset = "0xB20470", VA = "0x10B21670")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F2F0")]
    [Address(RVA = "0xB21010", Offset = "0xB1FE10", VA = "0x10B21010")]
    public static void Initialize()
    {
    }

    [Token(Token = "0x600F2F1")]
    [Address(RVA = "0xB211F0", Offset = "0xB1FFF0", VA = "0x10B211F0")]
    public static void SetAuthDeviceData(Dictionary<string, object> data)
    {
    }
  }
}
