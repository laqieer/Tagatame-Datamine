// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusDraftDeckParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A5C")]
  public sealed class JSON_VersusDraftDeckParamFormatter : 
    IMessagePackFormatter<JSON_VersusDraftDeckParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001948")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001949")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002862")]
    [Address(RVA = "0xECDFD0", Offset = "0xECCDD0", VA = "0x10ECDFD0")]
    public JSON_VersusDraftDeckParamFormatter()
    {
    }

    [Token(Token = "0x6002863")]
    [Address(RVA = "0xECDE70", Offset = "0xECCC70", VA = "0x10ECDE70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusDraftDeckParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002864")]
    [Address(RVA = "0xECDB20", Offset = "0xECC920", VA = "0x10ECDB20", Slot = "5")]
    public JSON_VersusDraftDeckParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusDraftDeckParam) null;
    }
  }
}
