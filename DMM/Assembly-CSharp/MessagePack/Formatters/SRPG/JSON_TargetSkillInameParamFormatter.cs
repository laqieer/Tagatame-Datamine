// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TargetSkillInameParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006FB")]
  public sealed class JSON_TargetSkillInameParamFormatter : 
    IMessagePackFormatter<JSON_TargetSkillInameParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400128E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400128F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E3F")]
    [Address(RVA = "0xC39410", Offset = "0xC38210", VA = "0x10C39410")]
    public JSON_TargetSkillInameParamFormatter()
    {
    }

    [Token(Token = "0x6001E40")]
    [Address(RVA = "0xC39310", Offset = "0xC38110", VA = "0x10C39310", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TargetSkillInameParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E41")]
    [Address(RVA = "0xC39040", Offset = "0xC37E40", VA = "0x10C39040", Slot = "5")]
    public JSON_TargetSkillInameParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TargetSkillInameParam) null;
    }
  }
}
