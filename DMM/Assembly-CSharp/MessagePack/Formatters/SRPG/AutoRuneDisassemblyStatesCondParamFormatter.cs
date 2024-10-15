// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AutoRuneDisassemblyStatesCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ACB")]
  public sealed class AutoRuneDisassemblyStatesCondParamFormatter : 
    IMessagePackFormatter<AutoRuneDisassemblyStatesCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A26")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A27")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029AF")]
    [Address(RVA = "0xF02820", Offset = "0xF01620", VA = "0x10F02820")]
    public AutoRuneDisassemblyStatesCondParamFormatter()
    {
    }

    [Token(Token = "0x60029B0")]
    [Address(RVA = "0xF026F0", Offset = "0xF014F0", VA = "0x10F026F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AutoRuneDisassemblyStatesCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029B1")]
    [Address(RVA = "0xF02410", Offset = "0xF01210", VA = "0x10F02410", Slot = "5")]
    public AutoRuneDisassemblyStatesCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AutoRuneDisassemblyStatesCondParam) null;
    }
  }
}
