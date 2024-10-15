// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqExpansionPurchase_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009CA")]
  public sealed class ReqExpansionPurchase_ResponseFormatter : 
    IMessagePackFormatter<ReqExpansionPurchase.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001824")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001825")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026AC")]
    [Address(RVA = "0xE77BB0", Offset = "0xE769B0", VA = "0x10E77BB0")]
    public ReqExpansionPurchase_ResponseFormatter()
    {
    }

    [Token(Token = "0x60026AD")]
    [Address(RVA = "0xE77A40", Offset = "0xE76840", VA = "0x10E77A40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqExpansionPurchase.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026AE")]
    [Address(RVA = "0xE77770", Offset = "0xE76570", VA = "0x10E77770", Slot = "5")]
    public ReqExpansionPurchase.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqExpansionPurchase.Response) null;
    }
  }
}
