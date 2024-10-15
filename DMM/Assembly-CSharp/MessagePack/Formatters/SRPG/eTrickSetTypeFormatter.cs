// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eTrickSetTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200054F")]
  public sealed class eTrickSetTypeFormatter : 
    IMessagePackFormatter<eTrickSetType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600193B")]
    [Address(RVA = "0x6B1A20", Offset = "0x6B0820", VA = "0x106B1A20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eTrickSetType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600193C")]
    [Address(RVA = "0x6B19D0", Offset = "0x6B07D0", VA = "0x106B19D0", Slot = "5")]
    public eTrickSetType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eTrickSetType();
    }

    [Token(Token = "0x600193D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eTrickSetTypeFormatter()
    {
    }
  }
}
