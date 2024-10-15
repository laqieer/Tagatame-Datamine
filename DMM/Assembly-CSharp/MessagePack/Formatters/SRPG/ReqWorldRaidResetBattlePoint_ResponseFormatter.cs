// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqWorldRaidResetBattlePoint_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007E3")]
  public sealed class ReqWorldRaidResetBattlePoint_ResponseFormatter : 
    IMessagePackFormatter<ReqWorldRaidResetBattlePoint.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001456")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001457")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020F7")]
    [Address(RVA = "0xD3D150", Offset = "0xD3BF50", VA = "0x10D3D150")]
    public ReqWorldRaidResetBattlePoint_ResponseFormatter()
    {
    }

    [Token(Token = "0x60020F8")]
    [Address(RVA = "0xD3CF70", Offset = "0xD3BD70", VA = "0x10D3CF70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqWorldRaidResetBattlePoint.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020F9")]
    [Address(RVA = "0xD3CC30", Offset = "0xD3BA30", VA = "0x10D3CC30", Slot = "5")]
    public ReqWorldRaidResetBattlePoint.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqWorldRaidResetBattlePoint.Response) null;
    }
  }
}
