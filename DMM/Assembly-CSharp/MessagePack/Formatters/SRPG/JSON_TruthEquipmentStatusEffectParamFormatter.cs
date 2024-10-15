// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TruthEquipmentStatusEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006AC")]
  public sealed class JSON_TruthEquipmentStatusEffectParamFormatter : 
    IMessagePackFormatter<JSON_TruthEquipmentStatusEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011F0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011F1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D52")]
    [Address(RVA = "0xC0B360", Offset = "0xC0A160", VA = "0x10C0B360")]
    public JSON_TruthEquipmentStatusEffectParamFormatter()
    {
    }

    [Token(Token = "0x6001D53")]
    [Address(RVA = "0xC0B230", Offset = "0xC0A030", VA = "0x10C0B230", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TruthEquipmentStatusEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D54")]
    [Address(RVA = "0xC0AF10", Offset = "0xC09D10", VA = "0x10C0AF10", Slot = "5")]
    public JSON_TruthEquipmentStatusEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TruthEquipmentStatusEffectParam) null;
    }
  }
}
