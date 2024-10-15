// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TruthEquipmentAbilityParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200097A")]
  public sealed class TruthEquipmentAbilityParamFormatter : 
    IMessagePackFormatter<TruthEquipmentAbilityParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001784")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001785")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025BC")]
    [Address(RVA = "0xE36400", Offset = "0xE35200", VA = "0x10E36400")]
    public TruthEquipmentAbilityParamFormatter()
    {
    }

    [Token(Token = "0x60025BD")]
    [Address(RVA = "0xE361E0", Offset = "0xE34FE0", VA = "0x10E361E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TruthEquipmentAbilityParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025BE")]
    [Address(RVA = "0xE35ED0", Offset = "0xE34CD0", VA = "0x10E35ED0", Slot = "5")]
    public TruthEquipmentAbilityParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TruthEquipmentAbilityParam) null;
    }
  }
}
