// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.Device
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth
{
  [Token(Token = "0x200365E")]
  public class Device : IDevice
  {
    [Token(Token = "0x400FF63")]
    [FieldOffset(Offset = "0x8")]
    public readonly string IDFA;
    [Token(Token = "0x400FF64")]
    [FieldOffset(Offset = "0xC")]
    public readonly string ID;

    [Token(Token = "0x1700230F")]
    public static Device Instance
    {
      [Token(Token = "0x600F319"), Address(RVA = "0xB21590", Offset = "0xB20390", VA = "0x10B21590")] get
      {
        return (Device) null;
      }
      [Token(Token = "0x600F31A"), Address(RVA = "0xB21710", Offset = "0xB20510", VA = "0x10B21710")] private set
      {
      }
    }

    [Token(Token = "0x17002310")]
    public string Platform
    {
      [Token(Token = "0x600F31B"), Address(RVA = "0xB215C0", Offset = "0xB203C0", VA = "0x10B215C0", Slot = "6")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002311")]
    public bool initialized
    {
      [Token(Token = "0x600F31C"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002312")]
    public bool hasError
    {
      [Token(Token = "0x600F31D"), Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F31E")]
    [Address(RVA = "0xB214E0", Offset = "0xB202E0", VA = "0x10B214E0")]
    public Device()
    {
    }
  }
}
