// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TobiraConditionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200060A")]
  public sealed class JSON_TobiraConditionParamFormatter : 
    IMessagePackFormatter<JSON_TobiraConditionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010AC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010AD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B6C")]
    [Address(RVA = "0xBAA410", Offset = "0xBA9210", VA = "0x10BAA410")]
    public JSON_TobiraConditionParamFormatter()
    {
    }

    [Token(Token = "0x6001B6D")]
    [Address(RVA = "0xBAA2E0", Offset = "0xBA90E0", VA = "0x10BAA2E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TobiraConditionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B6E")]
    [Address(RVA = "0xBA9FD0", Offset = "0xBA8DD0", VA = "0x10BA9FD0", Slot = "5")]
    public JSON_TobiraConditionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TobiraConditionParam) null;
    }
  }
}
