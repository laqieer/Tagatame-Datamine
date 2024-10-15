// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAutoRepeatQuestBoxAdd_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200095B")]
  public sealed class ReqAutoRepeatQuestBoxAdd_ResponseFormatter : 
    IMessagePackFormatter<ReqAutoRepeatQuestBoxAdd.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001746")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001747")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600255F")]
    [Address(RVA = "0xE18870", Offset = "0xE17670", VA = "0x10E18870")]
    public ReqAutoRepeatQuestBoxAdd_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002560")]
    [Address(RVA = "0xE186A0", Offset = "0xE174A0", VA = "0x10E186A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAutoRepeatQuestBoxAdd.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002561")]
    [Address(RVA = "0xE182F0", Offset = "0xE170F0", VA = "0x10E182F0", Slot = "5")]
    public ReqAutoRepeatQuestBoxAdd.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAutoRepeatQuestBoxAdd.Response) null;
    }
  }
}
