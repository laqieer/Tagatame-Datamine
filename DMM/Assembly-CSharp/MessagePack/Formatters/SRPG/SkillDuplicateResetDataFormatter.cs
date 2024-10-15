// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillDuplicateResetDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200075D")]
  public sealed class SkillDuplicateResetDataFormatter : 
    IMessagePackFormatter<SkillDuplicateResetData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001352")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001353")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F65")]
    [Address(RVA = "0xC9B9F0", Offset = "0xC9A7F0", VA = "0x10C9B9F0")]
    public SkillDuplicateResetDataFormatter()
    {
    }

    [Token(Token = "0x6001F66")]
    [Address(RVA = "0xC9B860", Offset = "0xC9A660", VA = "0x10C9B860", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillDuplicateResetData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F67")]
    [Address(RVA = "0xC9B4F0", Offset = "0xC9A2F0", VA = "0x10C9B4F0", Slot = "5")]
    public SkillDuplicateResetData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillDuplicateResetData) null;
    }
  }
}
