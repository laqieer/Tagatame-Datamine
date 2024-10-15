// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillDistanceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007BB")]
  public sealed class SkillDistanceParamFormatter : 
    IMessagePackFormatter<SkillDistanceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001406")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001407")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600207F")]
    [Address(RVA = "0xD0BDD0", Offset = "0xD0ABD0", VA = "0x10D0BDD0")]
    public SkillDistanceParamFormatter()
    {
    }

    [Token(Token = "0x6002080")]
    [Address(RVA = "0xD0BA90", Offset = "0xD0A890", VA = "0x10D0BA90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillDistanceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002081")]
    [Address(RVA = "0xD0B6D0", Offset = "0xD0A4D0", VA = "0x10D0B6D0", Slot = "5")]
    public SkillDistanceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillDistanceParam) null;
    }
  }
}
