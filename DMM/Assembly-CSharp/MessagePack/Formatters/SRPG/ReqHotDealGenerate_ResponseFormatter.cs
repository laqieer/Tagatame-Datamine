// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqHotDealGenerate_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AE0")]
  public sealed class ReqHotDealGenerate_ResponseFormatter : 
    IMessagePackFormatter<ReqHotDealGenerate.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A50")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A51")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029EE")]
    [Address(RVA = "0xF2A850", Offset = "0xF29650", VA = "0x10F2A850")]
    public ReqHotDealGenerate_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029EF")]
    [Address(RVA = "0xF2A750", Offset = "0xF29550", VA = "0x10F2A750", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqHotDealGenerate.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029F0")]
    [Address(RVA = "0xF2A480", Offset = "0xF29280", VA = "0x10F2A480", Slot = "5")]
    public ReqHotDealGenerate.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqHotDealGenerate.Response) null;
    }
  }
}
