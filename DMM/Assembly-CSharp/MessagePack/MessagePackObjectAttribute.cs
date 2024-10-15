// Decompiled with JetBrains decompiler
// Type: MessagePack.MessagePackObjectAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x2000346")]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
  public class MessagePackObjectAttribute : Attribute
  {
    [Token(Token = "0x170001F3")]
    public bool KeyAsPropertyName
    {
      [Token(Token = "0x6001173"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
      [Token(Token = "0x6001174"), Address(RVA = "0x3011A0", Offset = "0x2FFFA0", VA = "0x103011A0")] private set
      {
      }
    }

    [Token(Token = "0x6001175")]
    [Address(RVA = "0x301170", Offset = "0x2FFF70", VA = "0x10301170")]
    public MessagePackObjectAttribute(bool keyAsPropertyName = false)
    {
    }
  }
}
