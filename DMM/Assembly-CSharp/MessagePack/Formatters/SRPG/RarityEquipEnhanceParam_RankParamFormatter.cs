// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RarityEquipEnhanceParam_RankParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000772")]
  public sealed class RarityEquipEnhanceParam_RankParamFormatter : 
    IMessagePackFormatter<RarityEquipEnhanceParam.RankParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400137C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400137D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FA4")]
    [Address(RVA = "0xCB3B20", Offset = "0xCB2920", VA = "0x10CB3B20")]
    public RarityEquipEnhanceParam_RankParamFormatter()
    {
    }

    [Token(Token = "0x6001FA5")]
    [Address(RVA = "0xCB3940", Offset = "0xCB2740", VA = "0x10CB3940", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RarityEquipEnhanceParam.RankParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FA6")]
    [Address(RVA = "0xCB35F0", Offset = "0xCB23F0", VA = "0x10CB35F0", Slot = "5")]
    public RarityEquipEnhanceParam.RankParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RarityEquipEnhanceParam.RankParam) null;
    }
  }
}
