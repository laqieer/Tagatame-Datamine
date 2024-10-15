// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneDisassemblyFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008FB")]
  public sealed class RuneDisassemblyFormatter : 
    IMessagePackFormatter<RuneDisassembly>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001686")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001687")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600243F")]
    [Address(RVA = "0xDEE470", Offset = "0xDED270", VA = "0x10DEE470")]
    public RuneDisassemblyFormatter()
    {
    }

    [Token(Token = "0x6002440")]
    [Address(RVA = "0xDEE2C0", Offset = "0xDED0C0", VA = "0x10DEE2C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneDisassembly value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002441")]
    [Address(RVA = "0xDEDF30", Offset = "0xDECD30", VA = "0x10DEDF30", Slot = "5")]
    public RuneDisassembly Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneDisassembly) null;
    }
  }
}
