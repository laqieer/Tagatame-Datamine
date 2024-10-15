// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EquipTruthSettingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007C1")]
  public sealed class EquipTruthSettingFormatter : 
    IMessagePackFormatter<EquipTruthSetting>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001412")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001413")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002091")]
    [Address(RVA = "0xD03EE0", Offset = "0xD02CE0", VA = "0x10D03EE0")]
    public EquipTruthSettingFormatter()
    {
    }

    [Token(Token = "0x6002092")]
    [Address(RVA = "0xD03DB0", Offset = "0xD02BB0", VA = "0x10D03DB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EquipTruthSetting value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002093")]
    [Address(RVA = "0xD03AA0", Offset = "0xD028A0", VA = "0x10D03AA0", Slot = "5")]
    public EquipTruthSetting Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EquipTruthSetting) null;
    }
  }
}
