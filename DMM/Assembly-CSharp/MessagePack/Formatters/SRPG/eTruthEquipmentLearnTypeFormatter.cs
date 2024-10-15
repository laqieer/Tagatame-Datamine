// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eTruthEquipmentLearnTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000593")]
  public sealed class eTruthEquipmentLearnTypeFormatter : 
    IMessagePackFormatter<eTruthEquipmentLearnType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001A07")]
    [Address(RVA = "0x7A4F50", Offset = "0x7A3D50", VA = "0x107A4F50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eTruthEquipmentLearnType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A08")]
    [Address(RVA = "0x7A4F00", Offset = "0x7A3D00", VA = "0x107A4F00", Slot = "5")]
    public eTruthEquipmentLearnType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eTruthEquipmentLearnType();
    }

    [Token(Token = "0x6001A09")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eTruthEquipmentLearnTypeFormatter()
    {
    }
  }
}
