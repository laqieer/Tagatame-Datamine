// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EAbilityTypeDetailFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200056B")]
  public sealed class EAbilityTypeDetailFormatter : 
    IMessagePackFormatter<EAbilityTypeDetail>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600198F")]
    [Address(RVA = "0x69B180", Offset = "0x699F80", VA = "0x1069B180", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EAbilityTypeDetail value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001990")]
    [Address(RVA = "0x69B130", Offset = "0x699F30", VA = "0x1069B130", Slot = "5")]
    public EAbilityTypeDetail Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EAbilityTypeDetail();
    }

    [Token(Token = "0x6001991")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EAbilityTypeDetailFormatter()
    {
    }
  }
}
