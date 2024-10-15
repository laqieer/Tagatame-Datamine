// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TruthEquipmentLvEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AB6")]
  public sealed class TruthEquipmentLvEffectParamFormatter : 
    IMessagePackFormatter<TruthEquipmentLvEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019FC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019FD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002970")]
    [Address(RVA = "0xF183D0", Offset = "0xF171D0", VA = "0x10F183D0")]
    public TruthEquipmentLvEffectParamFormatter()
    {
    }

    [Token(Token = "0x6002971")]
    [Address(RVA = "0xF18220", Offset = "0xF17020", VA = "0x10F18220", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TruthEquipmentLvEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002972")]
    [Address(RVA = "0xF17F50", Offset = "0xF16D50", VA = "0x10F17F50", Slot = "5")]
    public TruthEquipmentLvEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TruthEquipmentLvEffectParam) null;
    }
  }
}
