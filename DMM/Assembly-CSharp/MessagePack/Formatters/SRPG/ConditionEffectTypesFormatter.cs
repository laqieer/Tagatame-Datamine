// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ConditionEffectTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000577")]
  public sealed class ConditionEffectTypesFormatter : 
    IMessagePackFormatter<ConditionEffectTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019B3")]
    [Address(RVA = "0x697340", Offset = "0x696140", VA = "0x10697340", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ConditionEffectTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019B4")]
    [Address(RVA = "0x6972F0", Offset = "0x6960F0", VA = "0x106972F0", Slot = "5")]
    public ConditionEffectTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ConditionEffectTypes();
    }

    [Token(Token = "0x60019B5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConditionEffectTypesFormatter()
    {
    }
  }
}
