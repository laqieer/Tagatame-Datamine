// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000676")]
  public sealed class JSON_RuneParamFormatter : 
    IMessagePackFormatter<JSON_RuneParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001184")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001185")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CB0")]
    [Address(RVA = "0xBEC2A0", Offset = "0xBEB0A0", VA = "0x10BEC2A0")]
    public JSON_RuneParamFormatter()
    {
    }

    [Token(Token = "0x6001CB1")]
    [Address(RVA = "0xBEC030", Offset = "0xBEAE30", VA = "0x10BEC030", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CB2")]
    [Address(RVA = "0xBEBBF0", Offset = "0xBEA9F0", VA = "0x10BEBBF0", Slot = "5")]
    public JSON_RuneParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneParam) null;
    }
  }
}
