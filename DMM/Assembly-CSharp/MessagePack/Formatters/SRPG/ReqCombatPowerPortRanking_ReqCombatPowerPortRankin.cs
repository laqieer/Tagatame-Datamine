// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCombatPowerPortRanking_ReqCombatPowerPortRankingResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008C2")]
  public sealed class ReqCombatPowerPortRanking_ReqCombatPowerPortRankingResponseFormatter : 
    IMessagePackFormatter<ReqCombatPowerPortRanking.ReqCombatPowerPortRankingResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001614")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001615")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002394")]
    [Address(RVA = "0xDD6BE0", Offset = "0xDD59E0", VA = "0x10DD6BE0")]
    public ReqCombatPowerPortRanking_ReqCombatPowerPortRankingResponseFormatter()
    {
    }

    [Token(Token = "0x6002395")]
    [Address(RVA = "0xDD68F0", Offset = "0xDD56F0", VA = "0x10DD68F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCombatPowerPortRanking.ReqCombatPowerPortRankingResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002396")]
    [Address(RVA = "0xDD64C0", Offset = "0xDD52C0", VA = "0x10DD64C0", Slot = "5")]
    public ReqCombatPowerPortRanking.ReqCombatPowerPortRankingResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCombatPowerPortRanking.ReqCombatPowerPortRankingResponse) null;
    }
  }
}
