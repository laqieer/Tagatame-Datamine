// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EquipSkillSettingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007BD")]
  public sealed class EquipSkillSettingFormatter : 
    IMessagePackFormatter<EquipSkillSetting>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400140A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400140B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002085")]
    [Address(RVA = "0xD03840", Offset = "0xD02640", VA = "0x10D03840")]
    public EquipSkillSettingFormatter()
    {
    }

    [Token(Token = "0x6002086")]
    [Address(RVA = "0xD035F0", Offset = "0xD023F0", VA = "0x10D035F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EquipSkillSetting value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002087")]
    [Address(RVA = "0xD031C0", Offset = "0xD01FC0", VA = "0x10D031C0", Slot = "5")]
    public EquipSkillSetting Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EquipSkillSetting) null;
    }
  }
}
