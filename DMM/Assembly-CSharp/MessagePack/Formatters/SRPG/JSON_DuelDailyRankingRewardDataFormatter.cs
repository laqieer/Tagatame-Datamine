// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelDailyRankingRewardDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000909")]
  public sealed class JSON_DuelDailyRankingRewardDataFormatter : 
    IMessagePackFormatter<JSON_DuelDailyRankingRewardData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016A2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016A3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002469")]
    [Address(RVA = "0xDE1580", Offset = "0xDE0380", VA = "0x10DE1580")]
    public JSON_DuelDailyRankingRewardDataFormatter()
    {
    }

    [Token(Token = "0x600246A")]
    [Address(RVA = "0xDE13A0", Offset = "0xDE01A0", VA = "0x10DE13A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelDailyRankingRewardData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600246B")]
    [Address(RVA = "0xDE0FD0", Offset = "0xDDFDD0", VA = "0x10DE0FD0", Slot = "5")]
    public JSON_DuelDailyRankingRewardData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelDailyRankingRewardData) null;
    }
  }
}
