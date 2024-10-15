// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AutoRuneDisassemblyStateParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ACC")]
  public sealed class AutoRuneDisassemblyStateParamFormatter : 
    IMessagePackFormatter<AutoRuneDisassemblyStateParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A28")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A29")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029B2")]
    [Address(RVA = "0xF02290", Offset = "0xF01090", VA = "0x10F02290")]
    public AutoRuneDisassemblyStateParamFormatter()
    {
    }

    [Token(Token = "0x60029B3")]
    [Address(RVA = "0xF020B0", Offset = "0xF00EB0", VA = "0x10F020B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AutoRuneDisassemblyStateParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029B4")]
    [Address(RVA = "0xF01DA0", Offset = "0xF00BA0", VA = "0x10F01DA0", Slot = "5")]
    public AutoRuneDisassemblyStateParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AutoRuneDisassemblyStateParam) null;
    }
  }
}
