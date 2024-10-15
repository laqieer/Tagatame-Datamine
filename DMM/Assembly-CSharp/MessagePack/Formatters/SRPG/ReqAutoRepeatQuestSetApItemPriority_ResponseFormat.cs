// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAutoRepeatQuestSetApItemPriority_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A0C")]
  public sealed class ReqAutoRepeatQuestSetApItemPriority_ResponseFormatter : 
    IMessagePackFormatter<ReqAutoRepeatQuestSetApItemPriority.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018A8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018A9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002772")]
    [Address(RVA = "0xEA58D0", Offset = "0xEA46D0", VA = "0x10EA58D0")]
    public ReqAutoRepeatQuestSetApItemPriority_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002773")]
    [Address(RVA = "0xEA57D0", Offset = "0xEA45D0", VA = "0x10EA57D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAutoRepeatQuestSetApItemPriority.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002774")]
    [Address(RVA = "0xEA5500", Offset = "0xEA4300", VA = "0x10EA5500", Slot = "5")]
    public ReqAutoRepeatQuestSetApItemPriority.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAutoRepeatQuestSetApItemPriority.Response) null;
    }
  }
}
