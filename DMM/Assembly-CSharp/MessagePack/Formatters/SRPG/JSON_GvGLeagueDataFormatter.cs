// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGLeagueDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005CD")]
  public sealed class JSON_GvGLeagueDataFormatter : 
    IMessagePackFormatter<JSON_GvGLeagueData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001032")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001033")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AB5")]
    [Address(RVA = "0x950A10", Offset = "0x94F810", VA = "0x10950A10")]
    public JSON_GvGLeagueDataFormatter()
    {
    }

    [Token(Token = "0x6001AB6")]
    [Address(RVA = "0x9508B0", Offset = "0x94F6B0", VA = "0x109508B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGLeagueData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AB7")]
    [Address(RVA = "0x950560", Offset = "0x94F360", VA = "0x10950560", Slot = "5")]
    public JSON_GvGLeagueData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGLeagueData) null;
    }
  }
}
