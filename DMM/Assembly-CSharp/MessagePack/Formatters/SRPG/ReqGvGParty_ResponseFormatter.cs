// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGParty_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AC7")]
  public sealed class ReqGvGParty_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGParty.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A1E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A1F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029A3")]
    [Address(RVA = "0xF146F0", Offset = "0xF134F0", VA = "0x10F146F0")]
    public ReqGvGParty_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029A4")]
    [Address(RVA = "0xF14440", Offset = "0xF13240", VA = "0x10F14440", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGParty.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029A5")]
    [Address(RVA = "0xF14090", Offset = "0xF12E90", VA = "0x10F14090", Slot = "5")]
    public ReqGvGParty.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGParty.Response) null;
    }
  }
}
