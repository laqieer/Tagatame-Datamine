// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusCoinCampParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000907")]
  public sealed class JSON_VersusCoinCampParamFormatter : 
    IMessagePackFormatter<JSON_VersusCoinCampParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400169E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400169F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002463")]
    [Address(RVA = "0xDE65C0", Offset = "0xDE53C0", VA = "0x10DE65C0")]
    public JSON_VersusCoinCampParamFormatter()
    {
    }

    [Token(Token = "0x6002464")]
    [Address(RVA = "0xDE63E0", Offset = "0xDE51E0", VA = "0x10DE63E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusCoinCampParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002465")]
    [Address(RVA = "0xDE6030", Offset = "0xDE4E30", VA = "0x10DE6030", Slot = "5")]
    public JSON_VersusCoinCampParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusCoinCampParam) null;
    }
  }
}
