// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusTagatameCupParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A76")]
  public sealed class JSON_VersusTagatameCupParamFormatter : 
    IMessagePackFormatter<JSON_VersusTagatameCupParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400197C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400197D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028B0")]
    [Address(RVA = "0xEE7440", Offset = "0xEE6240", VA = "0x10EE7440")]
    public JSON_VersusTagatameCupParamFormatter()
    {
    }

    [Token(Token = "0x60028B1")]
    [Address(RVA = "0xEE7170", Offset = "0xEE5F70", VA = "0x10EE7170", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusTagatameCupParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028B2")]
    [Address(RVA = "0xEE6CE0", Offset = "0xEE5AE0", VA = "0x10EE6CE0", Slot = "5")]
    public JSON_VersusTagatameCupParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusTagatameCupParam) null;
    }
  }
}
