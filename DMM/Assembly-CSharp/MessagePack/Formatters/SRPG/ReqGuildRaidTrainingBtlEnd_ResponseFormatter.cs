// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidTrainingBtlEnd_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B34")]
  public sealed class ReqGuildRaidTrainingBtlEnd_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidTrainingBtlEnd.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AF8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AF9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AEA")]
    [Address(RVA = "0xF6CFC0", Offset = "0xF6BDC0", VA = "0x10F6CFC0")]
    public ReqGuildRaidTrainingBtlEnd_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AEB")]
    [Address(RVA = "0xF6B840", Offset = "0xF6A640", VA = "0x10F6B840", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidTrainingBtlEnd.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AEC")]
    [Address(RVA = "0xF6A630", Offset = "0xF69430", VA = "0x10F6A630", Slot = "5")]
    public ReqGuildRaidTrainingBtlEnd.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidTrainingBtlEnd.Response) null;
    }
  }
}
