// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqBondRest_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AE2")]
  public sealed class ReqBondRest_ResponseFormatter : 
    IMessagePackFormatter<ReqBondRest.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A54")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A55")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029F4")]
    [Address(RVA = "0xF265F0", Offset = "0xF253F0", VA = "0x10F265F0")]
    public ReqBondRest_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029F5")]
    [Address(RVA = "0xF26210", Offset = "0xF25010", VA = "0x10F26210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqBondRest.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029F6")]
    [Address(RVA = "0xF25E10", Offset = "0xF24C10", VA = "0x10F25E10", Slot = "5")]
    public ReqBondRest.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqBondRest.Response) null;
    }
  }
}
