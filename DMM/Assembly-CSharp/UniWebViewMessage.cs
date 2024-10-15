// Decompiled with JetBrains decompiler
// Type: UniWebViewMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000327")]
public struct UniWebViewMessage
{
  [Token(Token = "0x170001E6")]
  public string RawMessage
  {
    [Token(Token = "0x60010E8"), Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060")] readonly get
    {
      return (string) null;
    }
    [Token(Token = "0x60010E9"), Address(RVA = "0xB01110", Offset = "0xAFFF10", VA = "0x10B01110")] private set
    {
    }
  }

  [Token(Token = "0x170001E7")]
  public string Scheme
  {
    [Token(Token = "0x60010EA"), Address(RVA = "0x28E4C0", Offset = "0x28D2C0", VA = "0x1028E4C0")] readonly get
    {
      return (string) null;
    }
    [Token(Token = "0x60010EB"), Address(RVA = "0x2EC6F0", Offset = "0x2EB4F0", VA = "0x102EC6F0")] private set
    {
    }
  }

  [Token(Token = "0x170001E8")]
  public string Path
  {
    [Token(Token = "0x60010EC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] readonly get
    {
      return (string) null;
    }
    [Token(Token = "0x60010ED"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
    {
    }
  }

  [Token(Token = "0x170001E9")]
  public Dictionary<string, string> Args
  {
    [Token(Token = "0x60010EE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] readonly get
    {
      return (Dictionary<string, string>) null;
    }
    [Token(Token = "0x60010EF"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
    {
    }
  }

  [Token(Token = "0x60010F0")]
  [Address(RVA = "0x12AB7F0", Offset = "0x12AA5F0", VA = "0x112AB7F0")]
  public UniWebViewMessage(string rawMessage)
  {
  }
}
