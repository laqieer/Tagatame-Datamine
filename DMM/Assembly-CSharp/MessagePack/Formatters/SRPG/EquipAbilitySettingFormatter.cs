// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EquipAbilitySettingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007BE")]
  public sealed class EquipAbilitySettingFormatter : 
    IMessagePackFormatter<EquipAbilitySetting>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400140C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400140D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002088")]
    [Address(RVA = "0xD00C50", Offset = "0xCFFA50", VA = "0x10D00C50")]
    public EquipAbilitySettingFormatter()
    {
    }

    [Token(Token = "0x6002089")]
    [Address(RVA = "0xD009F0", Offset = "0xCFF7F0", VA = "0x10D009F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EquipAbilitySetting value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600208A")]
    [Address(RVA = "0xD00620", Offset = "0xCFF420", VA = "0x10D00620", Slot = "5")]
    public EquipAbilitySetting Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EquipAbilitySetting) null;
    }
  }
}
