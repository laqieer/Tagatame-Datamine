// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AutoRuneDisassemblyParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A16")]
  public sealed class AutoRuneDisassemblyParamFormatter : 
    IMessagePackFormatter<AutoRuneDisassemblyParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018BC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018BD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002790")]
    [Address(RVA = "0xE921A0", Offset = "0xE90FA0", VA = "0x10E921A0")]
    public AutoRuneDisassemblyParamFormatter()
    {
    }

    [Token(Token = "0x6002791")]
    [Address(RVA = "0xE91FC0", Offset = "0xE90DC0", VA = "0x10E91FC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AutoRuneDisassemblyParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002792")]
    [Address(RVA = "0xE91CD0", Offset = "0xE90AD0", VA = "0x10E91CD0", Slot = "5")]
    public AutoRuneDisassemblyParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AutoRuneDisassemblyParam) null;
    }
  }
}
