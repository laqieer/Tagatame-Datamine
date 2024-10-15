// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TruthEquipmentDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000799")]
  public sealed class TruthEquipmentDataFormatter : 
    IMessagePackFormatter<TruthEquipmentData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013CA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013CB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002019")]
    [Address(RVA = "0xCE4230", Offset = "0xCE3030", VA = "0x10CE4230")]
    public TruthEquipmentDataFormatter()
    {
    }

    [Token(Token = "0x600201A")]
    [Address(RVA = "0xCE41C0", Offset = "0xCE2FC0", VA = "0x10CE41C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TruthEquipmentData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600201B")]
    [Address(RVA = "0xCE3F50", Offset = "0xCE2D50", VA = "0x10CE3F50", Slot = "5")]
    public TruthEquipmentData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TruthEquipmentData) null;
    }
  }
}
