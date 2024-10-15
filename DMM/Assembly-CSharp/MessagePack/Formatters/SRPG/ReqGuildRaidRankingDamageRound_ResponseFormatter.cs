// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidRankingDamageRound_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000865")]
  public sealed class ReqGuildRaidRankingDamageRound_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidRankingDamageRound.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400155A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400155B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600227D")]
    [Address(RVA = "0xD97C20", Offset = "0xD96A20", VA = "0x10D97C20")]
    public ReqGuildRaidRankingDamageRound_ResponseFormatter()
    {
    }

    [Token(Token = "0x600227E")]
    [Address(RVA = "0xD97A70", Offset = "0xD96870", VA = "0x10D97A70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidRankingDamageRound.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600227F")]
    [Address(RVA = "0xD97760", Offset = "0xD96560", VA = "0x10D97760", Slot = "5")]
    public ReqGuildRaidRankingDamageRound.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidRankingDamageRound.Response) null;
    }
  }
}
