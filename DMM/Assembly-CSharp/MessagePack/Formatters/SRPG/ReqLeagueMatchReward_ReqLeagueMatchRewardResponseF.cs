// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqLeagueMatchReward_ReqLeagueMatchRewardResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000837")]
  public sealed class ReqLeagueMatchReward_ReqLeagueMatchRewardResponseFormatter : 
    IMessagePackFormatter<ReqLeagueMatchReward.ReqLeagueMatchRewardResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014FE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014FF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021F3")]
    [Address(RVA = "0xD7E460", Offset = "0xD7D260", VA = "0x10D7E460")]
    public ReqLeagueMatchReward_ReqLeagueMatchRewardResponseFormatter()
    {
    }

    [Token(Token = "0x60021F4")]
    [Address(RVA = "0xD7E170", Offset = "0xD7CF70", VA = "0x10D7E170", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqLeagueMatchReward.ReqLeagueMatchRewardResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021F5")]
    [Address(RVA = "0xD7DD40", Offset = "0xD7CB40", VA = "0x10D7DD40", Slot = "5")]
    public ReqLeagueMatchReward.ReqLeagueMatchRewardResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqLeagueMatchReward.ReqLeagueMatchRewardResponse) null;
    }
  }
}
