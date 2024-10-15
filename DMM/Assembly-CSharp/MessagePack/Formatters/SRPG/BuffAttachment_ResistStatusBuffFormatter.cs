// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BuffAttachment_ResistStatusBuffFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007AB")]
  public sealed class BuffAttachment_ResistStatusBuffFormatter : 
    IMessagePackFormatter<BuffAttachment.ResistStatusBuff>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600204F")]
    [Address(RVA = "0xCEFBF0", Offset = "0xCEE9F0", VA = "0x10CEFBF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BuffAttachment.ResistStatusBuff value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002050")]
    [Address(RVA = "0xCEF9D0", Offset = "0xCEE7D0", VA = "0x10CEF9D0", Slot = "5")]
    public BuffAttachment.ResistStatusBuff Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BuffAttachment.ResistStatusBuff) null;
    }

    [Token(Token = "0x6002051")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuffAttachment_ResistStatusBuffFormatter()
    {
    }
  }
}
