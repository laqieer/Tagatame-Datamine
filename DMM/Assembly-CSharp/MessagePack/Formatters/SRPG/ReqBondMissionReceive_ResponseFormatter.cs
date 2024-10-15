// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqBondMissionReceive_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009E7")]
  public sealed class ReqBondMissionReceive_ResponseFormatter : 
    IMessagePackFormatter<ReqBondMissionReceive.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400185E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400185F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002703")]
    [Address(RVA = "0xE8A9B0", Offset = "0xE897B0", VA = "0x10E8A9B0")]
    public ReqBondMissionReceive_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002704")]
    [Address(RVA = "0xE8A600", Offset = "0xE89400", VA = "0x10E8A600", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqBondMissionReceive.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002705")]
    [Address(RVA = "0xE8A120", Offset = "0xE88F20", VA = "0x10E8A120", Slot = "5")]
    public ReqBondMissionReceive.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqBondMissionReceive.Response) null;
    }
  }
}
