// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelChainWinPointParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000809")]
  public sealed class JSON_DuelChainWinPointParamFormatter : 
    IMessagePackFormatter<JSON_DuelChainWinPointParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014A2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014A3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002169")]
    [Address(RVA = "0xD40430", Offset = "0xD3F230", VA = "0x10D40430")]
    public JSON_DuelChainWinPointParamFormatter()
    {
    }

    [Token(Token = "0x600216A")]
    [Address(RVA = "0xD40330", Offset = "0xD3F130", VA = "0x10D40330", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelChainWinPointParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600216B")]
    [Address(RVA = "0xD40050", Offset = "0xD3EE50", VA = "0x10D40050", Slot = "5")]
    public JSON_DuelChainWinPointParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelChainWinPointParam) null;
    }
  }
}
