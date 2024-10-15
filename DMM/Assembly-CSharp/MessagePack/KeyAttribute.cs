// Decompiled with JetBrains decompiler
// Type: MessagePack.KeyAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x2000347")]
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
  public class KeyAttribute : Attribute
  {
    [Token(Token = "0x170001F4")]
    public int? IntKey
    {
      [Token(Token = "0x6001176"), Address(RVA = "0x2ECBB0", Offset = "0x2EB9B0", VA = "0x102ECBB0")] get
      {
        return new int?();
      }
      [Token(Token = "0x6001177"), Address(RVA = "0x2E2BB0", Offset = "0x2E19B0", VA = "0x102E2BB0")] private set
      {
      }
    }

    [Token(Token = "0x170001F5")]
    public string StringKey
    {
      [Token(Token = "0x6001178"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6001179"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x600117A")]
    [Address(RVA = "0x2ECB20", Offset = "0x2EB920", VA = "0x102ECB20")]
    public KeyAttribute(int x)
    {
    }

    [Token(Token = "0x600117B")]
    [Address(RVA = "0x2ECB80", Offset = "0x2EB980", VA = "0x102ECB80")]
    public KeyAttribute(string x)
    {
    }
  }
}
