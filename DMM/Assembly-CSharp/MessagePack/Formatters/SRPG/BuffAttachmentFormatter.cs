// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BuffAttachmentFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007AC")]
  public sealed class BuffAttachmentFormatter : 
    IMessagePackFormatter<BuffAttachment>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013EA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013EB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002052")]
    [Address(RVA = "0xCEEF90", Offset = "0xCEDD90", VA = "0x10CEEF90")]
    public BuffAttachmentFormatter()
    {
    }

    [Token(Token = "0x6002053")]
    [Address(RVA = "0xCEE430", Offset = "0xCED230", VA = "0x10CEE430", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BuffAttachment value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002054")]
    [Address(RVA = "0xCED9E0", Offset = "0xCEC7E0", VA = "0x10CED9E0", Slot = "5")]
    public BuffAttachment Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BuffAttachment) null;
    }
  }
}
