// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillAdditionalParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000755")]
  public sealed class SkillAdditionalParamFormatter : 
    IMessagePackFormatter<SkillAdditionalParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001342")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001343")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F4D")]
    [Address(RVA = "0xC99570", Offset = "0xC98370", VA = "0x10C99570")]
    public SkillAdditionalParamFormatter()
    {
    }

    [Token(Token = "0x6001F4E")]
    [Address(RVA = "0xC99220", Offset = "0xC98020", VA = "0x10C99220", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillAdditionalParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F4F")]
    [Address(RVA = "0xC98E90", Offset = "0xC97C90", VA = "0x10C98E90", Slot = "5")]
    public SkillAdditionalParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillAdditionalParam) null;
    }
  }
}
