// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.PrimitiveObjectFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000500")]
  public sealed class PrimitiveObjectFormatter : IMessagePackFormatter<object>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F8F")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<object> Instance;
    [Token(Token = "0x4000F90")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Dictionary<Type, int> typeToJumpCode;

    [Token(Token = "0x6001830")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private PrimitiveObjectFormatter()
    {
    }

    [Token(Token = "0x6001831")]
    [Address(RVA = "0x6A8A90", Offset = "0x6A7890", VA = "0x106A8A90")]
    public static bool IsSupportedType(Type type, TypeInfo typeInfo, object value) => new bool();

    [Token(Token = "0x6001832")]
    [Address(RVA = "0x6A8B70", Offset = "0x6A7970", VA = "0x106A8B70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      object value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001833")]
    [Address(RVA = "0x6A81A0", Offset = "0x6A6FA0", VA = "0x106A81A0", Slot = "5")]
    public object Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (object) null;
    }

    [Token(Token = "0x6001834")]
    [Address(RVA = "0x6A96F0", Offset = "0x6A84F0", VA = "0x106A96F0")]
    static PrimitiveObjectFormatter()
    {
    }
  }
}
