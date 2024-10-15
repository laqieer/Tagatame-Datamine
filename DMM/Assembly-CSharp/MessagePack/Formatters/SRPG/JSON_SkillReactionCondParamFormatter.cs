// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillReactionCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006FC")]
  public sealed class JSON_SkillReactionCondParamFormatter : 
    IMessagePackFormatter<JSON_SkillReactionCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001290")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001291")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E42")]
    [Address(RVA = "0xC38D10", Offset = "0xC37B10", VA = "0x10C38D10")]
    public JSON_SkillReactionCondParamFormatter()
    {
    }

    [Token(Token = "0x6001E43")]
    [Address(RVA = "0xC389D0", Offset = "0xC377D0", VA = "0x10C389D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillReactionCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E44")]
    [Address(RVA = "0xC38550", Offset = "0xC37350", VA = "0x10C38550", Slot = "5")]
    public JSON_SkillReactionCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillReactionCondParam) null;
    }
  }
}
