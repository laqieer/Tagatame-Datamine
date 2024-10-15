// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRunePrideOpen_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A17")]
  public sealed class ReqRunePrideOpen_ResponseFormatter : 
    IMessagePackFormatter<ReqRunePrideOpen.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018BE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018BF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002793")]
    [Address(RVA = "0xEA6D90", Offset = "0xEA5B90", VA = "0x10EA6D90")]
    public ReqRunePrideOpen_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002794")]
    [Address(RVA = "0xEA6C90", Offset = "0xEA5A90", VA = "0x10EA6C90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRunePrideOpen.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002795")]
    [Address(RVA = "0xEA69C0", Offset = "0xEA57C0", VA = "0x10EA69C0", Slot = "5")]
    public ReqRunePrideOpen.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRunePrideOpen.Response) null;
    }
  }
}
