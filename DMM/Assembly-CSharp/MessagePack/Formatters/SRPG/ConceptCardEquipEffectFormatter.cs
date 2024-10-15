// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ConceptCardEquipEffectFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200077F")]
  public sealed class ConceptCardEquipEffectFormatter : 
    IMessagePackFormatter<ConceptCardEquipEffect>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001396")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001397")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FCB")]
    [Address(RVA = "0xCC9260", Offset = "0xCC8060", VA = "0x10CC9260")]
    public ConceptCardEquipEffectFormatter()
    {
    }

    [Token(Token = "0x6001FCC")]
    [Address(RVA = "0xCC8DF0", Offset = "0xCC7BF0", VA = "0x10CC8DF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ConceptCardEquipEffect value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FCD")]
    [Address(RVA = "0xCC8A00", Offset = "0xCC7800", VA = "0x10CC8A00", Slot = "5")]
    public ConceptCardEquipEffect Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ConceptCardEquipEffect) null;
    }
  }
}
