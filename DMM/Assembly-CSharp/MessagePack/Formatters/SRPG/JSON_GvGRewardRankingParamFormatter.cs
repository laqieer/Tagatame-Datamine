// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGRewardRankingParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200095E")]
  public sealed class JSON_GvGRewardRankingParamFormatter : 
    IMessagePackFormatter<JSON_GvGRewardRankingParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400174C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400174D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002568")]
    [Address(RVA = "0xE15D20", Offset = "0xE14B20", VA = "0x10E15D20")]
    public JSON_GvGRewardRankingParamFormatter()
    {
    }

    [Token(Token = "0x6002569")]
    [Address(RVA = "0xE15B40", Offset = "0xE14940", VA = "0x10E15B40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGRewardRankingParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600256A")]
    [Address(RVA = "0xE15800", Offset = "0xE14600", VA = "0x10E15800", Slot = "5")]
    public JSON_GvGRewardRankingParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGRewardRankingParam) null;
    }
  }
}
