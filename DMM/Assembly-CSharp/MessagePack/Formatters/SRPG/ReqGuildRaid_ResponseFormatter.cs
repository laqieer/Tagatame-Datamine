// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaid_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B2D")]
  public sealed class ReqGuildRaid_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaid.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AEA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AEB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AD5")]
    [Address(RVA = "0xF6EFC0", Offset = "0xF6DDC0", VA = "0x10F6EFC0")]
    public ReqGuildRaid_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AD6")]
    [Address(RVA = "0xF6E870", Offset = "0xF6D670", VA = "0x10F6E870", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaid.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AD7")]
    [Address(RVA = "0xF6E210", Offset = "0xF6D010", VA = "0x10F6E210", Slot = "5")]
    public ReqGuildRaid.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaid.Response) null;
    }
  }
}
