// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqSetConceptCard_OverWrite_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009F7")]
  public sealed class ReqSetConceptCard_OverWrite_ResponseFormatter : 
    IMessagePackFormatter<ReqSetConceptCard_OverWrite.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400187E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400187F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002733")]
    [Address(RVA = "0xE91530", Offset = "0xE90330", VA = "0x10E91530")]
    public ReqSetConceptCard_OverWrite_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002734")]
    [Address(RVA = "0xE913D0", Offset = "0xE901D0", VA = "0x10E913D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqSetConceptCard_OverWrite.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002735")]
    [Address(RVA = "0xE91090", Offset = "0xE8FE90", VA = "0x10E91090", Slot = "5")]
    public ReqSetConceptCard_OverWrite.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqSetConceptCard_OverWrite.Response) null;
    }
  }
}
