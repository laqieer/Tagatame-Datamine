// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.DynamicObjectTypeFallbackFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004B3")]
  public sealed class DynamicObjectTypeFallbackFormatter : 
    IMessagePackFormatter<object>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F44")]
    [FieldOffset(Offset = "0x8")]
    private readonly ThreadsafeTypeKeyHashTable<KeyValuePair<object, DynamicObjectTypeFallbackFormatter.SerializeMethod>> serializers;
    [Token(Token = "0x4000F45")]
    [FieldOffset(Offset = "0xC")]
    private readonly IFormatterResolver[] innerResolvers;

    [Token(Token = "0x600170B")]
    [Address(RVA = "0x69B000", Offset = "0x699E00", VA = "0x1069B000")]
    public DynamicObjectTypeFallbackFormatter(params IFormatterResolver[] innerResolvers)
    {
    }

    [Token(Token = "0x600170C")]
    [Address(RVA = "0x69A500", Offset = "0x699300", VA = "0x1069A500", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      object value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600170D")]
    [Address(RVA = "0x69A490", Offset = "0x699290", VA = "0x1069A490", Slot = "5")]
    public object Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (object) null;
    }

    [Token(Token = "0x20004B4")]
    private delegate int SerializeMethod(
      object dynamicFormatter,
      ref byte[] bytes,
      int offset,
      object value,
      IFormatterResolver formatterResolver);
  }
}
