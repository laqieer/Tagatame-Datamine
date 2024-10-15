// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneLotteryEvoStateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000783")]
  public sealed class RuneLotteryEvoStateFormatter : 
    IMessagePackFormatter<RuneLotteryEvoState>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400139E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400139F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FD7")]
    [Address(RVA = "0xCD2F80", Offset = "0xCD1D80", VA = "0x10CD2F80")]
    public RuneLotteryEvoStateFormatter()
    {
    }

    [Token(Token = "0x6001FD8")]
    [Address(RVA = "0xCD2D20", Offset = "0xCD1B20", VA = "0x10CD2D20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneLotteryEvoState value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FD9")]
    [Address(RVA = "0xCD2920", Offset = "0xCD1720", VA = "0x10CD2920", Slot = "5")]
    public RuneLotteryEvoState Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneLotteryEvoState) null;
    }
  }
}
