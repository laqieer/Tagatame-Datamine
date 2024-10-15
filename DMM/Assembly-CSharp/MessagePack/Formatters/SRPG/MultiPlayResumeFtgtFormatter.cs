// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeFtgtFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000744")]
  public sealed class MultiPlayResumeFtgtFormatter : 
    IMessagePackFormatter<MultiPlayResumeFtgt>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001320")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001321")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F1A")]
    [Address(RVA = "0xC8BE10", Offset = "0xC8AC10", VA = "0x10C8BE10")]
    public MultiPlayResumeFtgtFormatter()
    {
    }

    [Token(Token = "0x6001F1B")]
    [Address(RVA = "0xC8BD10", Offset = "0xC8AB10", VA = "0x10C8BD10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeFtgt value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F1C")]
    [Address(RVA = "0xC8BA30", Offset = "0xC8A830", VA = "0x10C8BA30", Slot = "5")]
    public MultiPlayResumeFtgt Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeFtgt) null;
    }
  }
}
