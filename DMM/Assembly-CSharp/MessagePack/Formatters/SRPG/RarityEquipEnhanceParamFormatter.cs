// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RarityEquipEnhanceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000773")]
  public sealed class RarityEquipEnhanceParamFormatter : 
    IMessagePackFormatter<RarityEquipEnhanceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400137E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400137F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FA7")]
    [Address(RVA = "0xCB3400", Offset = "0xCB2200", VA = "0x10CB3400")]
    public RarityEquipEnhanceParamFormatter()
    {
    }

    [Token(Token = "0x6001FA8")]
    [Address(RVA = "0xCB31B0", Offset = "0xCB1FB0", VA = "0x10CB31B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RarityEquipEnhanceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FA9")]
    [Address(RVA = "0xCB2E00", Offset = "0xCB1C00", VA = "0x10CB2E00", Slot = "5")]
    public RarityEquipEnhanceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RarityEquipEnhanceParam) null;
    }
  }
}
