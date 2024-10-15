// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RewardStatusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200058F")]
  public sealed class RewardStatusFormatter : 
    IMessagePackFormatter<ReqWorldRaidReward.RewardStatus>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019FB")]
    [Address(RVA = "0x7A4AF0", Offset = "0x7A38F0", VA = "0x107A4AF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqWorldRaidReward.RewardStatus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019FC")]
    [Address(RVA = "0x7A4AA0", Offset = "0x7A38A0", VA = "0x107A4AA0", Slot = "5")]
    public ReqWorldRaidReward.RewardStatus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ReqWorldRaidReward.RewardStatus();
    }

    [Token(Token = "0x60019FD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RewardStatusFormatter()
    {
    }
  }
}
