// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePridePotentialStatusLotteryDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000939")]
  public sealed class RunePridePotentialStatusLotteryDataFormatter : 
    IMessagePackFormatter<RunePridePotentialStatusLotteryData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001702")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001703")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024F9")]
    [Address(RVA = "0xE08EB0", Offset = "0xE07CB0", VA = "0x10E08EB0")]
    public RunePridePotentialStatusLotteryDataFormatter()
    {
    }

    [Token(Token = "0x60024FA")]
    [Address(RVA = "0xE08B90", Offset = "0xE07990", VA = "0x10E08B90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePridePotentialStatusLotteryData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024FB")]
    [Address(RVA = "0xE087B0", Offset = "0xE075B0", VA = "0x10E087B0", Slot = "5")]
    public RunePridePotentialStatusLotteryData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePridePotentialStatusLotteryData) null;
    }
  }
}
