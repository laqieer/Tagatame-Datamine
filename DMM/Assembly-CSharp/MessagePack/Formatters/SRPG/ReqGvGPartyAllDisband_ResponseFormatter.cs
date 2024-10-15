// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGPartyAllDisband_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008D1")]
  public sealed class ReqGvGPartyAllDisband_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGPartyAllDisband.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001632")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001633")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023C1")]
    [Address(RVA = "0xDD9BB0", Offset = "0xDD89B0", VA = "0x10DD9BB0")]
    public ReqGvGPartyAllDisband_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023C2")]
    [Address(RVA = "0xDD9980", Offset = "0xDD8780", VA = "0x10DD9980", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGPartyAllDisband.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023C3")]
    [Address(RVA = "0xDD9640", Offset = "0xDD8440", VA = "0x10DD9640", Slot = "5")]
    public ReqGvGPartyAllDisband.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGPartyAllDisband.Response) null;
    }
  }
}
