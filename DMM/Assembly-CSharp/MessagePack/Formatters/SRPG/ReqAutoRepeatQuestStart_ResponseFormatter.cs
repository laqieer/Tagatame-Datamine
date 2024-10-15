// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAutoRepeatQuestStart_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A22")]
  public sealed class ReqAutoRepeatQuestStart_ResponseFormatter : 
    IMessagePackFormatter<ReqAutoRepeatQuestStart.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018D4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018D5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027B4")]
    [Address(RVA = "0xEA6050", Offset = "0xEA4E50", VA = "0x10EA6050")]
    public ReqAutoRepeatQuestStart_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027B5")]
    [Address(RVA = "0xEA5DA0", Offset = "0xEA4BA0", VA = "0x10EA5DA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAutoRepeatQuestStart.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027B6")]
    [Address(RVA = "0xEA59F0", Offset = "0xEA47F0", VA = "0x10EA59F0", Slot = "5")]
    public ReqAutoRepeatQuestStart.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAutoRepeatQuestStart.Response) null;
    }
  }
}
