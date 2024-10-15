// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAutoRepeatQuestProgress_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AD5")]
  public sealed class ReqAutoRepeatQuestProgress_ResponseFormatter : 
    IMessagePackFormatter<ReqAutoRepeatQuestProgress.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A3A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A3B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029CD")]
    [Address(RVA = "0xF10DD0", Offset = "0xF0FBD0", VA = "0x10F10DD0")]
    public ReqAutoRepeatQuestProgress_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029CE")]
    [Address(RVA = "0xF10BF0", Offset = "0xF0F9F0", VA = "0x10F10BF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAutoRepeatQuestProgress.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029CF")]
    [Address(RVA = "0xF108A0", Offset = "0xF0F6A0", VA = "0x10F108A0", Slot = "5")]
    public ReqAutoRepeatQuestProgress.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAutoRepeatQuestProgress.Response) null;
    }
  }
}
