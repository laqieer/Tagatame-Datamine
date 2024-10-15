// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillDuplicateResetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200075E")]
  public sealed class SkillDuplicateResetParamFormatter : 
    IMessagePackFormatter<SkillDuplicateResetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001354")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001355")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F68")]
    [Address(RVA = "0xC9C0D0", Offset = "0xC9AED0", VA = "0x10C9C0D0")]
    public SkillDuplicateResetParamFormatter()
    {
    }

    [Token(Token = "0x6001F69")]
    [Address(RVA = "0xC9BEF0", Offset = "0xC9ACF0", VA = "0x10C9BEF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillDuplicateResetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F6A")]
    [Address(RVA = "0xC9BBE0", Offset = "0xC9A9E0", VA = "0x10C9BBE0", Slot = "5")]
    public SkillDuplicateResetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillDuplicateResetParam) null;
    }
  }
}
