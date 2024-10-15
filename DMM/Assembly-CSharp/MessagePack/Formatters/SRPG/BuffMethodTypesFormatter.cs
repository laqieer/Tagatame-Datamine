// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BuffMethodTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000566")]
  public sealed class BuffMethodTypesFormatter : 
    IMessagePackFormatter<BuffMethodTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001980")]
    [Address(RVA = "0x694AB0", Offset = "0x6938B0", VA = "0x10694AB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BuffMethodTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001981")]
    [Address(RVA = "0x694A60", Offset = "0x693860", VA = "0x10694A60", Slot = "5")]
    public BuffMethodTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new BuffMethodTypes();
    }

    [Token(Token = "0x6001982")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuffMethodTypesFormatter()
    {
    }
  }
}
