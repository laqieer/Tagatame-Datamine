// Decompiled with JetBrains decompiler
// Type: MessagePack.UnionAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x2000349")]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
  public class UnionAttribute : Attribute
  {
    [Token(Token = "0x170001F6")]
    public int Key
    {
      [Token(Token = "0x600117D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600117E"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x170001F7")]
    public Type SubType
    {
      [Token(Token = "0x600117F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Type) null;
      }
      [Token(Token = "0x6001180"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x6001181")]
    [Address(RVA = "0x305B10", Offset = "0x304910", VA = "0x10305B10")]
    public UnionAttribute(int key, Type subType)
    {
    }
  }
}
