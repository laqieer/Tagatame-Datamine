// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eDamageDispTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200054D")]
  public sealed class eDamageDispTypeFormatter : 
    IMessagePackFormatter<eDamageDispType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001935")]
    [Address(RVA = "0x6B13E0", Offset = "0x6B01E0", VA = "0x106B13E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eDamageDispType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001936")]
    [Address(RVA = "0x6B1390", Offset = "0x6B0190", VA = "0x106B1390", Slot = "5")]
    public eDamageDispType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eDamageDispType();
    }

    [Token(Token = "0x6001937")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eDamageDispTypeFormatter()
    {
    }
  }
}
