// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCombatPowerPlayerRanking_ReqCombatPowerPlayerRankingResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008C0")]
  public sealed class ReqCombatPowerPlayerRanking_ReqCombatPowerPlayerRankingResponseFormatter : 
    IMessagePackFormatter<ReqCombatPowerPlayerRanking.ReqCombatPowerPlayerRankingResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001610")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001611")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600238E")]
    [Address(RVA = "0xDC32D0", Offset = "0xDC20D0", VA = "0x10DC32D0")]
    public ReqCombatPowerPlayerRanking_ReqCombatPowerPlayerRankingResponseFormatter()
    {
    }

    [Token(Token = "0x600238F")]
    [Address(RVA = "0xDC2FE0", Offset = "0xDC1DE0", VA = "0x10DC2FE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCombatPowerPlayerRanking.ReqCombatPowerPlayerRankingResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002390")]
    [Address(RVA = "0xDC2BB0", Offset = "0xDC19B0", VA = "0x10DC2BB0", Slot = "5")]
    public ReqCombatPowerPlayerRanking.ReqCombatPowerPlayerRankingResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCombatPowerPlayerRanking.ReqCombatPowerPlayerRankingResponse) null;
    }
  }
}
