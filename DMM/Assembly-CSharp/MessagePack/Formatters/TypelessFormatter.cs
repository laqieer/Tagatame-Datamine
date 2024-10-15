// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.TypelessFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200051C")]
  public sealed class TypelessFormatter : IMessagePackFormatter<object>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FA1")]
    public const sbyte ExtensionTypeCode = 100;
    [Token(Token = "0x4000FA2")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Regex SubtractFullNameRegex;
    [Token(Token = "0x4000FA3")]
    [FieldOffset(Offset = "0x4")]
    public static readonly IMessagePackFormatter<object> Instance;
    [Token(Token = "0x4000FA4")]
    [FieldOffset(Offset = "0x8")]
    private static readonly ThreadsafeTypeKeyHashTable<KeyValuePair<object, TypelessFormatter.SerializeMethod>> serializers;
    [Token(Token = "0x4000FA5")]
    [FieldOffset(Offset = "0xC")]
    private static readonly ThreadsafeTypeKeyHashTable<KeyValuePair<object, TypelessFormatter.DeserializeMethod>> deserializers;
    [Token(Token = "0x4000FA6")]
    [FieldOffset(Offset = "0x10")]
    private static readonly ThreadsafeTypeKeyHashTable<byte[]> typeNameCache;
    [Token(Token = "0x4000FA7")]
    [FieldOffset(Offset = "0x14")]
    private static readonly AsymmetricKeyHashTable<byte[], ArraySegment<byte>, Type> typeCache;
    [Token(Token = "0x4000FA8")]
    [FieldOffset(Offset = "0x18")]
    private static readonly HashSet<string> blacklistCheck;
    [Token(Token = "0x4000FA9")]
    [FieldOffset(Offset = "0x1C")]
    private static readonly HashSet<Type> useBuiltinTypes;
    [Token(Token = "0x4000FAB")]
    [FieldOffset(Offset = "0x24")]
    private static bool isMscorlib;
    [Token(Token = "0x4000FAC")]
    [FieldOffset(Offset = "0x25")]
    public static bool RemoveAssemblyVersion;

    [Token(Token = "0x17000212")]
    public static Func<string, Type> BindToType
    {
      [Token(Token = "0x6001893"), Address(RVA = "0x6ADF00", Offset = "0x6ACD00", VA = "0x106ADF00")] get
      {
        return (Func<string, Type>) null;
      }
      [Token(Token = "0x6001894"), Address(RVA = "0x6ADF40", Offset = "0x6ACD40", VA = "0x106ADF40")] set
      {
      }
    }

    [Token(Token = "0x6001895")]
    [Address(RVA = "0x6AB700", Offset = "0x6AA500", VA = "0x106AB700")]
    private static Type DefaultBindToType(string typeName) => (Type) null;

    [Token(Token = "0x6001896")]
    [Address(RVA = "0x6AD5B0", Offset = "0x6AC3B0", VA = "0x106AD5B0")]
    static TypelessFormatter()
    {
    }

    [Token(Token = "0x6001897")]
    [Address(RVA = "0x6AB5E0", Offset = "0x6AA3E0", VA = "0x106AB5E0")]
    private static string BuildTypeName(Type type) => (string) null;

    [Token(Token = "0x6001898")]
    [Address(RVA = "0x6AC720", Offset = "0x6AB520", VA = "0x106AC720", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      object value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001899")]
    [Address(RVA = "0x6AC540", Offset = "0x6AB340", VA = "0x106AC540", Slot = "5")]
    public object Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (object) null;
    }

    [Token(Token = "0x600189A")]
    [Address(RVA = "0x6AB770", Offset = "0x6AA570", VA = "0x106AB770")]
    private object DeserializeByTypeName(
      ArraySegment<byte> typeName,
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (object) null;
    }

    [Token(Token = "0x600189B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TypelessFormatter()
    {
    }

    [Token(Token = "0x200051D")]
    private delegate int SerializeMethod(
      object dynamicContractlessFormatter,
      ref byte[] bytes,
      int offset,
      object value,
      IFormatterResolver formatterResolver);

    [Token(Token = "0x200051E")]
    private delegate object DeserializeMethod(
      object dynamicContractlessFormatter,
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize);
  }
}
