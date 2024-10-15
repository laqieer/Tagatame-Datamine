// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneLotteryStateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008F8")]
  public sealed class RuneLotteryStateFormatter : 
    IMessagePackFormatter<RuneLotteryState>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001680")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001681")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002436")]
    [Address(RVA = "0xDF0180", Offset = "0xDEEF80", VA = "0x10DF0180")]
    public RuneLotteryStateFormatter()
    {
    }

    [Token(Token = "0x6002437")]
    [Address(RVA = "0xDEFF20", Offset = "0xDEED20", VA = "0x10DEFF20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneLotteryState value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002438")]
    [Address(RVA = "0xDEFB20", Offset = "0xDEE920", VA = "0x10DEFB20", Slot = "5")]
    public RuneLotteryState Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneLotteryState) null;
    }
  }
}
