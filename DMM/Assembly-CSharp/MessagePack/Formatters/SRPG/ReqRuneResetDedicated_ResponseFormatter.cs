// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneResetDedicated_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009A0")]
  public sealed class ReqRuneResetDedicated_ResponseFormatter : 
    IMessagePackFormatter<ReqRuneResetDedicated.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017D0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017D1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600262E")]
    [Address(RVA = "0xE487C0", Offset = "0xE475C0", VA = "0x10E487C0")]
    public ReqRuneResetDedicated_ResponseFormatter()
    {
    }

    [Token(Token = "0x600262F")]
    [Address(RVA = "0xE48660", Offset = "0xE47460", VA = "0x10E48660", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneResetDedicated.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002630")]
    [Address(RVA = "0xE48320", Offset = "0xE47120", VA = "0x10E48320", Slot = "5")]
    public ReqRuneResetDedicated.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneResetDedicated.Response) null;
    }
  }
}
