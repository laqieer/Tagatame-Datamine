// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGLeagueParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000911")]
  public sealed class JSON_GvGLeagueParamFormatter : 
    IMessagePackFormatter<JSON_GvGLeagueParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016B2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016B3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002481")]
    [Address(RVA = "0xDE53D0", Offset = "0xDE41D0", VA = "0x10DE53D0")]
    public JSON_GvGLeagueParamFormatter()
    {
    }

    [Token(Token = "0x6002482")]
    [Address(RVA = "0xDE50D0", Offset = "0xDE3ED0", VA = "0x10DE50D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGLeagueParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002483")]
    [Address(RVA = "0xDE4C00", Offset = "0xDE3A00", VA = "0x10DE4C00", Slot = "5")]
    public JSON_GvGLeagueParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGLeagueParam) null;
    }
  }
}
