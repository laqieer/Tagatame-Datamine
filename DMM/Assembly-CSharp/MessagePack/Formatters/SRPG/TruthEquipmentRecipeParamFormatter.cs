// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TruthEquipmentRecipeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009A8")]
  public sealed class TruthEquipmentRecipeParamFormatter : 
    IMessagePackFormatter<TruthEquipmentRecipeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017E0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017E1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002646")]
    [Address(RVA = "0xE4E060", Offset = "0xE4CE60", VA = "0x10E4E060")]
    public TruthEquipmentRecipeParamFormatter()
    {
    }

    [Token(Token = "0x6002647")]
    [Address(RVA = "0xE4DE40", Offset = "0xE4CC40", VA = "0x10E4DE40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TruthEquipmentRecipeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002648")]
    [Address(RVA = "0xE4DB00", Offset = "0xE4C900", VA = "0x10E4DB00", Slot = "5")]
    public TruthEquipmentRecipeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TruthEquipmentRecipeParam) null;
    }
  }
}
