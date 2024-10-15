// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeAutoHpJudgeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200074A")]
  public sealed class MultiPlayResumeAutoHpJudgeFormatter : 
    IMessagePackFormatter<MultiPlayResumeAutoHpJudge>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400132C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400132D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F2C")]
    [Address(RVA = "0xC89A20", Offset = "0xC88820", VA = "0x10C89A20")]
    public MultiPlayResumeAutoHpJudgeFormatter()
    {
    }

    [Token(Token = "0x6001F2D")]
    [Address(RVA = "0xC89840", Offset = "0xC88640", VA = "0x10C89840", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeAutoHpJudge value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F2E")]
    [Address(RVA = "0xC89500", Offset = "0xC88300", VA = "0x10C89500", Slot = "5")]
    public MultiPlayResumeAutoHpJudge Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeAutoHpJudge) null;
    }
  }
}
