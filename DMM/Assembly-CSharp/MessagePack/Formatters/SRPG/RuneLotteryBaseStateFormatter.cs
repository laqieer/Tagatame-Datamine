// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneLotteryBaseStateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000781")]
  public sealed class RuneLotteryBaseStateFormatter : 
    IMessagePackFormatter<RuneLotteryBaseState>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400139A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400139B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FD1")]
    [Address(RVA = "0xCD2580", Offset = "0xCD1380", VA = "0x10CD2580")]
    public RuneLotteryBaseStateFormatter()
    {
    }

    [Token(Token = "0x6001FD2")]
    [Address(RVA = "0xCD2200", Offset = "0xCD1000", VA = "0x10CD2200", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneLotteryBaseState value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FD3")]
    [Address(RVA = "0xCD1D50", Offset = "0xCD0B50", VA = "0x10CD1D50", Slot = "5")]
    public RuneLotteryBaseState Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneLotteryBaseState) null;
    }
  }
}
