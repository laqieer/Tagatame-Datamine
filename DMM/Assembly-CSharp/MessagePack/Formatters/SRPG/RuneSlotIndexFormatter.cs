// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneSlotIndexFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008F5")]
  public sealed class RuneSlotIndexFormatter : 
    IMessagePackFormatter<RuneSlotIndex>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400167A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400167B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600242D")]
    [Address(RVA = "0xDF36B0", Offset = "0xDF24B0", VA = "0x10DF36B0")]
    public RuneSlotIndexFormatter()
    {
    }

    [Token(Token = "0x600242E")]
    [Address(RVA = "0xDF3660", Offset = "0xDF2460", VA = "0x10DF3660", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneSlotIndex value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600242F")]
    [Address(RVA = "0xDF33F0", Offset = "0xDF21F0", VA = "0x10DF33F0", Slot = "5")]
    public RuneSlotIndex Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new RuneSlotIndex();
    }
  }
}
