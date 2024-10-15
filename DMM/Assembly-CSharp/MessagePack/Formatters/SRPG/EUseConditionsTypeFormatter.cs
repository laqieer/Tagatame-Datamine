// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EUseConditionsTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200056A")]
  public sealed class EUseConditionsTypeFormatter : 
    IMessagePackFormatter<EUseConditionsType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600198C")]
    [Address(RVA = "0x69C300", Offset = "0x69B100", VA = "0x1069C300", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EUseConditionsType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600198D")]
    [Address(RVA = "0x69C2B0", Offset = "0x69B0B0", VA = "0x1069C2B0", Slot = "5")]
    public EUseConditionsType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EUseConditionsType();
    }

    [Token(Token = "0x600198E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EUseConditionsTypeFormatter()
    {
    }
  }
}
