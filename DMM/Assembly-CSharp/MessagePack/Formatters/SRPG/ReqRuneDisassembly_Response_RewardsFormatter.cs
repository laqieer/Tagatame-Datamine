// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneDisassembly_Response_RewardsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000995")]
  public sealed class ReqRuneDisassembly_Response_RewardsFormatter : 
    IMessagePackFormatter<ReqRuneDisassembly.Response.Rewards>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017BA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017BB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600260D")]
    [Address(RVA = "0xE43570", Offset = "0xE42370", VA = "0x10E43570")]
    public ReqRuneDisassembly_Response_RewardsFormatter()
    {
    }

    [Token(Token = "0x600260E")]
    [Address(RVA = "0xE43440", Offset = "0xE42240", VA = "0x10E43440", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneDisassembly.Response.Rewards value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600260F")]
    [Address(RVA = "0xE43130", Offset = "0xE41F30", VA = "0x10E43130", Slot = "5")]
    public ReqRuneDisassembly.Response.Rewards Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneDisassembly.Response.Rewards) null;
    }
  }
}
