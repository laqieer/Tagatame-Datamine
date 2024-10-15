// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneDisassembly_MaterialsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008FA")]
  public sealed class RuneDisassembly_MaterialsFormatter : 
    IMessagePackFormatter<RuneDisassembly.Materials>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001684")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001685")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600243C")]
    [Address(RVA = "0xDEEAA0", Offset = "0xDED8A0", VA = "0x10DEEAA0")]
    public RuneDisassembly_MaterialsFormatter()
    {
    }

    [Token(Token = "0x600243D")]
    [Address(RVA = "0xDEE970", Offset = "0xDED770", VA = "0x10DEE970", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneDisassembly.Materials value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600243E")]
    [Address(RVA = "0xDEE660", Offset = "0xDED460", VA = "0x10DEE660", Slot = "5")]
    public RuneDisassembly.Materials Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneDisassembly.Materials) null;
    }
  }
}
