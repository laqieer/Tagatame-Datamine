// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqDuelTop_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A57")]
  public sealed class ReqDuelTop_ResponseFormatter : 
    IMessagePackFormatter<ReqDuelTop.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400193E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400193F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002853")]
    [Address(RVA = "0xED32C0", Offset = "0xED20C0", VA = "0x10ED32C0")]
    public ReqDuelTop_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002854")]
    [Address(RVA = "0xED2BA0", Offset = "0xED19A0", VA = "0x10ED2BA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqDuelTop.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002855")]
    [Address(RVA = "0xED2520", Offset = "0xED1320", VA = "0x10ED2520", Slot = "5")]
    public ReqDuelTop.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqDuelTop.Response) null;
    }
  }
}
