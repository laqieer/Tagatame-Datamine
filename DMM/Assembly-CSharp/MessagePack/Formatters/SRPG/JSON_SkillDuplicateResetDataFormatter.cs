// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillDuplicateResetDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006AF")]
  public sealed class JSON_SkillDuplicateResetDataFormatter : 
    IMessagePackFormatter<JSON_SkillDuplicateResetData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011F6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011F7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D5B")]
    [Address(RVA = "0xC07110", Offset = "0xC05F10", VA = "0x10C07110")]
    public JSON_SkillDuplicateResetDataFormatter()
    {
    }

    [Token(Token = "0x6001D5C")]
    [Address(RVA = "0xC06F80", Offset = "0xC05D80", VA = "0x10C06F80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillDuplicateResetData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D5D")]
    [Address(RVA = "0xC06C10", Offset = "0xC05A10", VA = "0x10C06C10", Slot = "5")]
    public JSON_SkillDuplicateResetData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillDuplicateResetData) null;
    }
  }
}
