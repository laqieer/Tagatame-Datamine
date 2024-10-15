// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAutoRepeatQuestEnd_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008EC")]
  public sealed class ReqAutoRepeatQuestEnd_ResponseFormatter : 
    IMessagePackFormatter<ReqAutoRepeatQuestEnd.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001668")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001669")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002412")]
    [Address(RVA = "0xDE9CB0", Offset = "0xDE8AB0", VA = "0x10DE9CB0")]
    public ReqAutoRepeatQuestEnd_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002413")]
    [Address(RVA = "0xDE9230", Offset = "0xDE8030", VA = "0x10DE9230", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAutoRepeatQuestEnd.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002414")]
    [Address(RVA = "0xDE89D0", Offset = "0xDE77D0", VA = "0x10DE89D0", Slot = "5")]
    public ReqAutoRepeatQuestEnd.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAutoRepeatQuestEnd.Response) null;
    }
  }
}
