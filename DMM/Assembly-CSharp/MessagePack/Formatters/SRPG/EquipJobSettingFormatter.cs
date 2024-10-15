// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EquipJobSettingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007C3")]
  public sealed class EquipJobSettingFormatter : 
    IMessagePackFormatter<EquipJobSetting>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001416")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001417")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002097")]
    [Address(RVA = "0xD03040", Offset = "0xD01E40", VA = "0x10D03040")]
    public EquipJobSettingFormatter()
    {
    }

    [Token(Token = "0x6002098")]
    [Address(RVA = "0xD02F10", Offset = "0xD01D10", VA = "0x10D02F10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EquipJobSetting value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002099")]
    [Address(RVA = "0xD02C00", Offset = "0xD01A00", VA = "0x10D02C00", Slot = "5")]
    public EquipJobSetting Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EquipJobSetting) null;
    }
  }
}
