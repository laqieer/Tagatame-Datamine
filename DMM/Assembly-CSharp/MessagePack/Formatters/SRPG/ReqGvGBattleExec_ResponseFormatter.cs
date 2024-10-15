// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGBattleExec_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ADA")]
  public sealed class ReqGvGBattleExec_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGBattleExec.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A44")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A45")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029DC")]
    [Address(RVA = "0xF28F20", Offset = "0xF27D20", VA = "0x10F28F20")]
    public ReqGvGBattleExec_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029DD")]
    [Address(RVA = "0xF28DF0", Offset = "0xF27BF0", VA = "0x10F28DF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGBattleExec.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029DE")]
    [Address(RVA = "0xF28AE0", Offset = "0xF278E0", VA = "0x10F28AE0", Slot = "5")]
    public ReqGvGBattleExec.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGBattleExec.Response) null;
    }
  }
}
