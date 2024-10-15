// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRunePridePotentialSet_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008C8")]
  public sealed class ReqRunePridePotentialSet_ResponseFormatter : 
    IMessagePackFormatter<ReqRunePridePotentialSet.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001620")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001621")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023A6")]
    [Address(RVA = "0xDDAF90", Offset = "0xDD9D90", VA = "0x10DDAF90")]
    public ReqRunePridePotentialSet_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023A7")]
    [Address(RVA = "0xDDAE20", Offset = "0xDD9C20", VA = "0x10DDAE20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRunePridePotentialSet.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023A8")]
    [Address(RVA = "0xDDAB50", Offset = "0xDD9950", VA = "0x10DDAB50", Slot = "5")]
    public ReqRunePridePotentialSet.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRunePridePotentialSet.Response) null;
    }
  }
}
