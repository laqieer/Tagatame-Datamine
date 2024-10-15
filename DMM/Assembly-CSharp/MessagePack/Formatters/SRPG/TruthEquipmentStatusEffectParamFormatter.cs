// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TruthEquipmentStatusEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200091D")]
  public sealed class TruthEquipmentStatusEffectParamFormatter : 
    IMessagePackFormatter<TruthEquipmentStatusEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016CA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016CB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024A5")]
    [Address(RVA = "0xE09740", Offset = "0xE08540", VA = "0x10E09740")]
    public TruthEquipmentStatusEffectParamFormatter()
    {
    }

    [Token(Token = "0x60024A6")]
    [Address(RVA = "0xE09590", Offset = "0xE08390", VA = "0x10E09590", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TruthEquipmentStatusEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024A7")]
    [Address(RVA = "0xE09250", Offset = "0xE08050", VA = "0x10E09250", Slot = "5")]
    public TruthEquipmentStatusEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TruthEquipmentStatusEffectParam) null;
    }
  }
}
