// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAdventureHistory_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000972")]
  public sealed class ReqAdventureHistory_ResponseFormatter : 
    IMessagePackFormatter<ReqAdventureHistory.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001774")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001775")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025A4")]
    [Address(RVA = "0xE31470", Offset = "0xE30270", VA = "0x10E31470")]
    public ReqAdventureHistory_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025A5")]
    [Address(RVA = "0xE31300", Offset = "0xE30100", VA = "0x10E31300", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAdventureHistory.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025A6")]
    [Address(RVA = "0xE31030", Offset = "0xE2FE30", VA = "0x10E31030", Slot = "5")]
    public ReqAdventureHistory.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAdventureHistory.Response) null;
    }
  }
}
