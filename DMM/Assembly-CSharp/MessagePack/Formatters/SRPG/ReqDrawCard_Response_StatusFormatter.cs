// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqDrawCard_Response_StatusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A39")]
  public sealed class ReqDrawCard_Response_StatusFormatter : 
    IMessagePackFormatter<ReqDrawCard.Response.Status>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001902")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001903")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027F9")]
    [Address(RVA = "0xEB6D40", Offset = "0xEB5B40", VA = "0x10EB6D40")]
    public ReqDrawCard_Response_StatusFormatter()
    {
    }

    [Token(Token = "0x60027FA")]
    [Address(RVA = "0xEB6B60", Offset = "0xEB5960", VA = "0x10EB6B60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqDrawCard.Response.Status value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027FB")]
    [Address(RVA = "0xEB6810", Offset = "0xEB5610", VA = "0x10EB6810", Slot = "5")]
    public ReqDrawCard.Response.Status Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqDrawCard.Response.Status) null;
    }
  }
}
