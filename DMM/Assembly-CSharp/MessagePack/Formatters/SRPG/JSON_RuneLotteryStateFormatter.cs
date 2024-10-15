// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneLotteryStateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008F7")]
  public sealed class JSON_RuneLotteryStateFormatter : 
    IMessagePackFormatter<JSON_RuneLotteryState>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400167E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400167F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002433")]
    [Address(RVA = "0xDE5DD0", Offset = "0xDE4BD0", VA = "0x10DE5DD0")]
    public JSON_RuneLotteryStateFormatter()
    {
    }

    [Token(Token = "0x6002434")]
    [Address(RVA = "0xDE5B80", Offset = "0xDE4980", VA = "0x10DE5B80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneLotteryState value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002435")]
    [Address(RVA = "0xDE57E0", Offset = "0xDE45E0", VA = "0x10DE57E0", Slot = "5")]
    public JSON_RuneLotteryState Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneLotteryState) null;
    }
  }
}
