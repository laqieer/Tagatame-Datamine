// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_TobiraEnhanceMaxItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006BE")]
  public sealed class Json_TobiraEnhanceMaxItemParamFormatter : 
    IMessagePackFormatter<Json_TobiraEnhanceMaxItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001214")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001215")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D88")]
    [Address(RVA = "0xC23160", Offset = "0xC21F60", VA = "0x10C23160")]
    public Json_TobiraEnhanceMaxItemParamFormatter()
    {
    }

    [Token(Token = "0x6001D89")]
    [Address(RVA = "0xC22F80", Offset = "0xC21D80", VA = "0x10C22F80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_TobiraEnhanceMaxItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D8A")]
    [Address(RVA = "0xC22BD0", Offset = "0xC219D0", VA = "0x10C22BD0", Slot = "5")]
    public Json_TobiraEnhanceMaxItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_TobiraEnhanceMaxItemParam) null;
    }
  }
}
