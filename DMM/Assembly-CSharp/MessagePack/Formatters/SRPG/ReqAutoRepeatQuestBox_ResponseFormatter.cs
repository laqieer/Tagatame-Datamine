// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAutoRepeatQuestBox_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009AA")]
  public sealed class ReqAutoRepeatQuestBox_ResponseFormatter : 
    IMessagePackFormatter<ReqAutoRepeatQuestBox.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017E4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017E5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600264C")]
    [Address(RVA = "0xE40460", Offset = "0xE3F260", VA = "0x10E40460")]
    public ReqAutoRepeatQuestBox_ResponseFormatter()
    {
    }

    [Token(Token = "0x600264D")]
    [Address(RVA = "0xE40190", Offset = "0xE3EF90", VA = "0x10E40190", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAutoRepeatQuestBox.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600264E")]
    [Address(RVA = "0xE3FD60", Offset = "0xE3EB60", VA = "0x10E3FD60", Slot = "5")]
    public ReqAutoRepeatQuestBox.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAutoRepeatQuestBox.Response) null;
    }
  }
}
