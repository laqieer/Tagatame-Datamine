// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGPartySet_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ADD")]
  public sealed class ReqGvGPartySet_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGPartySet.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A4A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A4B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029E5")]
    [Address(RVA = "0xF2A290", Offset = "0xF29090", VA = "0x10F2A290")]
    public ReqGvGPartySet_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029E6")]
    [Address(RVA = "0xF29FE0", Offset = "0xF28DE0", VA = "0x10F29FE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGPartySet.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029E7")]
    [Address(RVA = "0xF29C20", Offset = "0xF28A20", VA = "0x10F29C20", Slot = "5")]
    public ReqGvGPartySet.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGPartySet.Response) null;
    }
  }
}
