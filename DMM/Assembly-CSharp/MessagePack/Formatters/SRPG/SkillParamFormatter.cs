// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000761")]
  public sealed class SkillParamFormatter : IMessagePackFormatter<SkillParam>, IMessagePackFormatter
  {
    [Token(Token = "0x400135A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400135B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F71")]
    [Address(RVA = "0xCA4CB0", Offset = "0xCA3AB0", VA = "0x10CA4CB0")]
    public SkillParamFormatter()
    {
    }

    [Token(Token = "0x6001F72")]
    [Address(RVA = "0xCA1410", Offset = "0xCA0210", VA = "0x10CA1410", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F73")]
    [Address(RVA = "0xC9E850", Offset = "0xC9D650", VA = "0x10C9E850", Slot = "5")]
    public SkillParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillParam) null;
    }
  }
}
