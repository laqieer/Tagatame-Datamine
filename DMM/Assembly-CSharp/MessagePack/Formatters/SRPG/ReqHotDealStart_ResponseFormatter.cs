// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqHotDealStart_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ADF")]
  public sealed class ReqHotDealStart_ResponseFormatter : 
    IMessagePackFormatter<ReqHotDealStart.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A4E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A4F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029EB")]
    [Address(RVA = "0xF2AD40", Offset = "0xF29B40", VA = "0x10F2AD40")]
    public ReqHotDealStart_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029EC")]
    [Address(RVA = "0xF2AC40", Offset = "0xF29A40", VA = "0x10F2AC40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqHotDealStart.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029ED")]
    [Address(RVA = "0xF2A970", Offset = "0xF29770", VA = "0x10F2A970", Slot = "5")]
    public ReqHotDealStart.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqHotDealStart.Response) null;
    }
  }
}
