// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGLeagueResultFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005D3")]
  public sealed class JSON_GvGLeagueResultFormatter : 
    IMessagePackFormatter<JSON_GvGLeagueResult>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400103E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400103F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AC7")]
    [Address(RVA = "0x951790", Offset = "0x950590", VA = "0x10951790")]
    public JSON_GvGLeagueResultFormatter()
    {
    }

    [Token(Token = "0x6001AC8")]
    [Address(RVA = "0x951640", Offset = "0x950440", VA = "0x10951640", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGLeagueResult value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AC9")]
    [Address(RVA = "0x951310", Offset = "0x950110", VA = "0x10951310", Slot = "5")]
    public JSON_GvGLeagueResult Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGLeagueResult) null;
    }
  }
}
