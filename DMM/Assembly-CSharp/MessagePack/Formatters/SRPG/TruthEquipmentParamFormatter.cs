// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TruthEquipmentParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AB7")]
  public sealed class TruthEquipmentParamFormatter : 
    IMessagePackFormatter<TruthEquipmentParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019FE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019FF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002973")]
    [Address(RVA = "0xF18BE0", Offset = "0xF179E0", VA = "0x10F18BE0")]
    public TruthEquipmentParamFormatter()
    {
    }

    [Token(Token = "0x6002974")]
    [Address(RVA = "0xF18900", Offset = "0xF17700", VA = "0x10F18900", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TruthEquipmentParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002975")]
    [Address(RVA = "0xF185C0", Offset = "0xF173C0", VA = "0x10F185C0", Slot = "5")]
    public TruthEquipmentParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TruthEquipmentParam) null;
    }
  }
}
