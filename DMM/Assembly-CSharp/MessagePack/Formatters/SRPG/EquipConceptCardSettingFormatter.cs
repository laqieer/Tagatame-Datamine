// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EquipConceptCardSettingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007C0")]
  public sealed class EquipConceptCardSettingFormatter : 
    IMessagePackFormatter<EquipConceptCardSetting>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001410")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001411")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600208E")]
    [Address(RVA = "0xD01C70", Offset = "0xD00A70", VA = "0x10D01C70")]
    public EquipConceptCardSettingFormatter()
    {
    }

    [Token(Token = "0x600208F")]
    [Address(RVA = "0xD01A30", Offset = "0xD00830", VA = "0x10D01A30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EquipConceptCardSetting value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002090")]
    [Address(RVA = "0xD01610", Offset = "0xD00410", VA = "0x10D01610", Slot = "5")]
    public EquipConceptCardSetting Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (EquipConceptCardSetting) null;
    }
  }
}
