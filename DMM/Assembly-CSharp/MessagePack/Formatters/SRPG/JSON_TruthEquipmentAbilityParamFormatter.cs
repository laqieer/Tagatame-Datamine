// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TruthEquipmentAbilityParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006AE")]
  public sealed class JSON_TruthEquipmentAbilityParamFormatter : 
    IMessagePackFormatter<JSON_TruthEquipmentAbilityParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011F4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011F5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D58")]
    [Address(RVA = "0xC08E70", Offset = "0xC07C70", VA = "0x10C08E70")]
    public JSON_TruthEquipmentAbilityParamFormatter()
    {
    }

    [Token(Token = "0x6001D59")]
    [Address(RVA = "0xC08C90", Offset = "0xC07A90", VA = "0x10C08C90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TruthEquipmentAbilityParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D5A")]
    [Address(RVA = "0xC088E0", Offset = "0xC076E0", VA = "0x10C088E0", Slot = "5")]
    public JSON_TruthEquipmentAbilityParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TruthEquipmentAbilityParam) null;
    }
  }
}
