// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EquipInameSettingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007C2")]
  public sealed class EquipInameSettingFormatter : 
    IMessagePackFormatter<EquipInameSetting>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001414")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001415")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002094")]
    [Address(RVA = "0xD02AE0", Offset = "0xD018E0", VA = "0x10D02AE0")]
    public EquipInameSettingFormatter()
    {
    }

    [Token(Token = "0x6002095")]
    [Address(RVA = "0xD029E0", Offset = "0xD017E0", VA = "0x10D029E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EquipInameSetting value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002096")]
    [Address(RVA = "0xD02710", Offset = "0xD01510", VA = "0x10D02710", Slot = "5")]
    public EquipInameSetting Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EquipInameSetting) null;
    }
  }
}
