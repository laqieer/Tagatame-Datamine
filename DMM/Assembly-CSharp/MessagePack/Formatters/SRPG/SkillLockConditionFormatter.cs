// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillLockConditionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000762")]
  public sealed class SkillLockConditionFormatter : 
    IMessagePackFormatter<SkillLockCondition>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400135C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400135D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F74")]
    [Address(RVA = "0xCB7A70", Offset = "0xCB6870", VA = "0x10CB7A70")]
    public SkillLockConditionFormatter()
    {
    }

    [Token(Token = "0x6001F75")]
    [Address(RVA = "0xCB7870", Offset = "0xCB6670", VA = "0x10CB7870", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillLockCondition value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F76")]
    [Address(RVA = "0xCB74A0", Offset = "0xCB62A0", VA = "0x10CB74A0", Slot = "5")]
    public SkillLockCondition Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillLockCondition) null;
    }
  }
}
