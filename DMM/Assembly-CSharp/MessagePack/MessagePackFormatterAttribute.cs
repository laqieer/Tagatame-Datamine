// Decompiled with JetBrains decompiler
// Type: MessagePack.MessagePackFormatterAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x200034B")]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
  public class MessagePackFormatterAttribute : Attribute
  {
    [Token(Token = "0x170001F8")]
    public Type FormatterType
    {
      [Token(Token = "0x6001183"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (Type) null;
      }
      [Token(Token = "0x6001184"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x170001F9")]
    public object[] Arguments
    {
      [Token(Token = "0x6001185"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (object[]) null;
      }
      [Token(Token = "0x6001186"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x6001187")]
    [Address(RVA = "0x3010C0", Offset = "0x2FFEC0", VA = "0x103010C0")]
    public MessagePackFormatterAttribute(Type formatterType)
    {
    }

    [Token(Token = "0x6001188")]
    [Address(RVA = "0x3010F0", Offset = "0x2FFEF0", VA = "0x103010F0")]
    public MessagePackFormatterAttribute(Type formatterType, params object[] arguments)
    {
    }
  }
}
