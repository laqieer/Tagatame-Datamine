// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidRankingRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009E4")]
  public sealed class JSON_WorldRaidRankingRewardParamFormatter : 
    IMessagePackFormatter<JSON_WorldRaidRankingRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001858")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001859")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026FA")]
    [Address(RVA = "0xE86880", Offset = "0xE85680", VA = "0x10E86880")]
    public JSON_WorldRaidRankingRewardParamFormatter()
    {
    }

    [Token(Token = "0x60026FB")]
    [Address(RVA = "0xE866A0", Offset = "0xE854A0", VA = "0x10E866A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidRankingRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026FC")]
    [Address(RVA = "0xE86360", Offset = "0xE85160", VA = "0x10E86360", Slot = "5")]
    public JSON_WorldRaidRankingRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidRankingRewardParam) null;
    }
  }
}
