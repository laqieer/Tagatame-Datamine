// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EventTriggerFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007CA")]
  public sealed class EventTriggerFormatter : 
    IMessagePackFormatter<EventTrigger>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001424")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001425")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020AC")]
    [Address(RVA = "0xD047F0", Offset = "0xD035F0", VA = "0x10D047F0")]
    public EventTriggerFormatter()
    {
    }

    [Token(Token = "0x60020AD")]
    [Address(RVA = "0xD044A0", Offset = "0xD032A0", VA = "0x10D044A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EventTrigger value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020AE")]
    [Address(RVA = "0xD04060", Offset = "0xD02E60", VA = "0x10D04060", Slot = "5")]
    public EventTrigger Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EventTrigger) null;
    }
  }
}
