// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillManipulatePierceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006BD")]
  public sealed class JSON_SkillManipulatePierceParamFormatter : 
    IMessagePackFormatter<JSON_SkillManipulatePierceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001212")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001213")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D85")]
    [Address(RVA = "0xC1DAA0", Offset = "0xC1C8A0", VA = "0x10C1DAA0")]
    public JSON_SkillManipulatePierceParamFormatter()
    {
    }

    [Token(Token = "0x6001D86")]
    [Address(RVA = "0xC1D800", Offset = "0xC1C600", VA = "0x10C1D800", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillManipulatePierceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D87")]
    [Address(RVA = "0xC1D390", Offset = "0xC1C190", VA = "0x10C1D390", Slot = "5")]
    public JSON_SkillManipulatePierceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillManipulatePierceParam) null;
    }
  }
}
