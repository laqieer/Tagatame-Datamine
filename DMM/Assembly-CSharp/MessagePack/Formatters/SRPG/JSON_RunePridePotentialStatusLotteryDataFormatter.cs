// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePridePotentialStatusLotteryDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006E8")]
  public sealed class JSON_RunePridePotentialStatusLotteryDataFormatter : 
    IMessagePackFormatter<JSON_RunePridePotentialStatusLotteryData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001268")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001269")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E06")]
    [Address(RVA = "0xC34430", Offset = "0xC33230", VA = "0x10C34430")]
    public JSON_RunePridePotentialStatusLotteryDataFormatter()
    {
    }

    [Token(Token = "0x6001E07")]
    [Address(RVA = "0xC341D0", Offset = "0xC32FD0", VA = "0x10C341D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePridePotentialStatusLotteryData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E08")]
    [Address(RVA = "0xC33D90", Offset = "0xC32B90", VA = "0x10C33D90", Slot = "5")]
    public JSON_RunePridePotentialStatusLotteryData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePridePotentialStatusLotteryData) null;
    }
  }
}
