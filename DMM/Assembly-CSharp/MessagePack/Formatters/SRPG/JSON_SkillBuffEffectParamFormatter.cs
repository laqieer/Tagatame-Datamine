// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillBuffEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006BF")]
  public sealed class JSON_SkillBuffEffectParamFormatter : 
    IMessagePackFormatter<JSON_SkillBuffEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001216")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001217")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D8B")]
    [Address(RVA = "0xC1C450", Offset = "0xC1B250", VA = "0x10C1C450")]
    public JSON_SkillBuffEffectParamFormatter()
    {
    }

    [Token(Token = "0x6001D8C")]
    [Address(RVA = "0xC1C1D0", Offset = "0xC1AFD0", VA = "0x10C1C1D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillBuffEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D8D")]
    [Address(RVA = "0xC1BDA0", Offset = "0xC1ABA0", VA = "0x10C1BDA0", Slot = "5")]
    public JSON_SkillBuffEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillBuffEffectParam) null;
    }
  }
}
