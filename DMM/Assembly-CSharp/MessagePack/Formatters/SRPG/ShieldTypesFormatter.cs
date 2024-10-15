// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ShieldTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000549")]
  public sealed class ShieldTypesFormatter : 
    IMessagePackFormatter<ShieldTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001929")]
    [Address(RVA = "0x6AA3C0", Offset = "0x6A91C0", VA = "0x106AA3C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ShieldTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600192A")]
    [Address(RVA = "0x6AA370", Offset = "0x6A9170", VA = "0x106AA370", Slot = "5")]
    public ShieldTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ShieldTypes();
    }

    [Token(Token = "0x600192B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ShieldTypesFormatter()
    {
    }
  }
}
