// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TruthEquipmentRecipeMaterialParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009A7")]
  public sealed class TruthEquipmentRecipeMaterialParamFormatter : 
    IMessagePackFormatter<TruthEquipmentRecipeMaterialParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017DE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017DF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002643")]
    [Address(RVA = "0xE4D980", Offset = "0xE4C780", VA = "0x10E4D980")]
    public TruthEquipmentRecipeMaterialParamFormatter()
    {
    }

    [Token(Token = "0x6002644")]
    [Address(RVA = "0xE4D850", Offset = "0xE4C650", VA = "0x10E4D850", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TruthEquipmentRecipeMaterialParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002645")]
    [Address(RVA = "0xE4D570", Offset = "0xE4C370", VA = "0x10E4D570", Slot = "5")]
    public TruthEquipmentRecipeMaterialParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TruthEquipmentRecipeMaterialParam) null;
    }
  }
}
