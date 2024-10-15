// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCombatPowerPortRanking_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008C1")]
  public sealed class ReqCombatPowerPortRanking_ResponseFormatter : 
    IMessagePackFormatter<ReqCombatPowerPortRanking.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001612")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001613")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002391")]
    [Address(RVA = "0xDD7500", Offset = "0xDD6300", VA = "0x10DD7500")]
    public ReqCombatPowerPortRanking_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002392")]
    [Address(RVA = "0xDD7290", Offset = "0xDD6090", VA = "0x10DD7290", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCombatPowerPortRanking.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002393")]
    [Address(RVA = "0xDD6F10", Offset = "0xDD5D10", VA = "0x10DD6F10", Slot = "5")]
    public ReqCombatPowerPortRanking.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCombatPowerPortRanking.Response) null;
    }
  }
}
