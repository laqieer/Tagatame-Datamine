// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqDuelRankingReward_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200090B")]
  public sealed class ReqDuelRankingReward_ResponseFormatter : 
    IMessagePackFormatter<ReqDuelRankingReward.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016A6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016A7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600246F")]
    [Address(RVA = "0xDEACF0", Offset = "0xDE9AF0", VA = "0x10DEACF0")]
    public ReqDuelRankingReward_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002470")]
    [Address(RVA = "0xDEA8E0", Offset = "0xDE96E0", VA = "0x10DEA8E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqDuelRankingReward.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002471")]
    [Address(RVA = "0xDEA410", Offset = "0xDE9210", VA = "0x10DEA410", Slot = "5")]
    public ReqDuelRankingReward.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqDuelRankingReward.Response) null;
    }
  }
}
