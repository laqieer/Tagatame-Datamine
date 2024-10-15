// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EAbilityTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000568")]
  public sealed class EAbilityTypeFormatter : 
    IMessagePackFormatter<EAbilityType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001986")]
    [Address(RVA = "0x69B220", Offset = "0x69A020", VA = "0x1069B220", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EAbilityType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001987")]
    [Address(RVA = "0x69B1D0", Offset = "0x699FD0", VA = "0x1069B1D0", Slot = "5")]
    public EAbilityType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EAbilityType();
    }

    [Token(Token = "0x6001988")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EAbilityTypeFormatter()
    {
    }
  }
}
