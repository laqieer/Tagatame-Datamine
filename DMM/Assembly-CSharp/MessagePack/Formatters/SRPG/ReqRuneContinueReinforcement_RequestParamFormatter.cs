// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneContinueReinforcement_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000992")]
  public sealed class ReqRuneContinueReinforcement_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneContinueReinforcement.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017B4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017B5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002604")]
    [Address(RVA = "0xE411F0", Offset = "0xE3FFF0", VA = "0x10E411F0")]
    public ReqRuneContinueReinforcement_RequestParamFormatter()
    {
    }

    [Token(Token = "0x6002605")]
    [Address(RVA = "0xE410C0", Offset = "0xE3FEC0", VA = "0x10E410C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneContinueReinforcement.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002606")]
    [Address(RVA = "0xE40D80", Offset = "0xE3FB80", VA = "0x10E40D80", Slot = "5")]
    public ReqRuneContinueReinforcement.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneContinueReinforcement.RequestParam) null;
    }
  }
}
