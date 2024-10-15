// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.DMMGamesStore.Device
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth.GAuth.DMMGamesStore
{
  [Token(Token = "0x2003678")]
  public class Device : IDevice
  {
    [Token(Token = "0x400FFA5")]
    [FieldOffset(Offset = "0x0")]
    public static Device Instance;

    [Token(Token = "0x1700233F")]
    public string Platform
    {
      [Token(Token = "0x600F3BB"), Address(RVA = "0xB215F0", Offset = "0xB203F0", VA = "0x10B215F0", Slot = "6")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002340")]
    public bool initialized
    {
      [Token(Token = "0x600F3BC"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002341")]
    public bool hasError
    {
      [Token(Token = "0x600F3BD"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190", Slot = "5")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F3BE"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
      {
      }
    }

    [Token(Token = "0x17002342")]
    public int ViewerId
    {
      [Token(Token = "0x600F3BF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3C0"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] set
      {
      }
    }

    [Token(Token = "0x17002343")]
    public string OnetimeToken
    {
      [Token(Token = "0x600F3C1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F3C2"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
    }

    [Token(Token = "0x600F3C3")]
    [Address(RVA = "0xB21350", Offset = "0xB20150", VA = "0x10B21350")]
    public Device()
    {
    }
  }
}
