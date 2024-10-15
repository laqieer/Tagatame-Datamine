// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeManipulateBreakFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200074C")]
  public sealed class MultiPlayResumeManipulateBreakFormatter : 
    IMessagePackFormatter<MultiPlayResumeManipulateBreak>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001330")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001331")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F32")]
    [Address(RVA = "0xC8C360", Offset = "0xC8B160", VA = "0x10C8C360")]
    public MultiPlayResumeManipulateBreakFormatter()
    {
    }

    [Token(Token = "0x6001F33")]
    [Address(RVA = "0xC8C260", Offset = "0xC8B060", VA = "0x10C8C260", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeManipulateBreak value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F34")]
    [Address(RVA = "0xC8BF90", Offset = "0xC8AD90", VA = "0x10C8BF90", Slot = "5")]
    public MultiPlayResumeManipulateBreak Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeManipulateBreak) null;
    }
  }
}
