// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EquipDtuSettingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007C6")]
  public sealed class EquipDtuSettingFormatter : 
    IMessagePackFormatter<EquipDtuSetting>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400141C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400141D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020A0")]
    [Address(RVA = "0xD02520", Offset = "0xD01320", VA = "0x10D02520")]
    public EquipDtuSettingFormatter()
    {
    }

    [Token(Token = "0x60020A1")]
    [Address(RVA = "0xD02350", Offset = "0xD01150", VA = "0x10D02350", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EquipDtuSetting value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020A2")]
    [Address(RVA = "0xD01FA0", Offset = "0xD00DA0", VA = "0x10D01FA0", Slot = "5")]
    public EquipDtuSetting Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EquipDtuSetting) null;
    }
  }
}
