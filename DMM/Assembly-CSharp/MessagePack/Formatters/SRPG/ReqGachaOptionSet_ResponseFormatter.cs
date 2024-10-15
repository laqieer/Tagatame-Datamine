// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGachaOptionSet_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AD3")]
  public sealed class ReqGachaOptionSet_ResponseFormatter : 
    IMessagePackFormatter<ReqGachaOptionSet.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A36")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A37")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029C7")]
    [Address(RVA = "0xF12480", Offset = "0xF11280", VA = "0x10F12480")]
    public ReqGachaOptionSet_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029C8")]
    [Address(RVA = "0xF12310", Offset = "0xF11110", VA = "0x10F12310", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGachaOptionSet.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029C9")]
    [Address(RVA = "0xF12040", Offset = "0xF10E40", VA = "0x10F12040", Slot = "5")]
    public ReqGachaOptionSet.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGachaOptionSet.Response) null;
    }
  }
}
