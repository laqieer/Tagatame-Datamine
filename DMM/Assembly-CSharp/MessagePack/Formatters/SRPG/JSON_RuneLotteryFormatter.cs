// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneLotteryFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000677")]
  public sealed class JSON_RuneLotteryFormatter : 
    IMessagePackFormatter<JSON_RuneLottery>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001186")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001187")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CB3")]
    [Address(RVA = "0xBEA640", Offset = "0xBE9440", VA = "0x10BEA640")]
    public JSON_RuneLotteryFormatter()
    {
    }

    [Token(Token = "0x6001CB4")]
    [Address(RVA = "0xBEA540", Offset = "0xBE9340", VA = "0x10BEA540", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneLottery value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CB5")]
    [Address(RVA = "0xBEA260", Offset = "0xBE9060", VA = "0x10BEA260", Slot = "5")]
    public JSON_RuneLottery Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneLottery) null;
    }
  }
}
