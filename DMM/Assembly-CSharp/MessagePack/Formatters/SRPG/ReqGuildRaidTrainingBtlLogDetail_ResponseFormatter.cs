// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidTrainingBtlLogDetail_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000874")]
  public sealed class ReqGuildRaidTrainingBtlLogDetail_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidTrainingBtlLogDetail.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001578")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001579")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022AA")]
    [Address(RVA = "0xDAAAA0", Offset = "0xDA98A0", VA = "0x10DAAAA0")]
    public ReqGuildRaidTrainingBtlLogDetail_ResponseFormatter()
    {
    }

    [Token(Token = "0x60022AB")]
    [Address(RVA = "0xDAA930", Offset = "0xDA9730", VA = "0x10DAA930", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidTrainingBtlLogDetail.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022AC")]
    [Address(RVA = "0xDAA660", Offset = "0xDA9460", VA = "0x10DAA660", Slot = "5")]
    public ReqGuildRaidTrainingBtlLogDetail.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidTrainingBtlLogDetail.Response) null;
    }
  }
}
