// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqStatusAwakeRest_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B00")]
  public sealed class ReqStatusAwakeRest_ResponseFormatter : 
    IMessagePackFormatter<ReqStatusAwakeRest.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A90")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A91")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A4E")]
    [Address(RVA = "0xF2C240", Offset = "0xF2B040", VA = "0x10F2C240")]
    public ReqStatusAwakeRest_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A4F")]
    [Address(RVA = "0xF2C0E0", Offset = "0xF2AEE0", VA = "0x10F2C0E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqStatusAwakeRest.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A50")]
    [Address(RVA = "0xF2BDA0", Offset = "0xF2ABA0", VA = "0x10F2BDA0", Slot = "5")]
    public ReqStatusAwakeRest.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqStatusAwakeRest.Response) null;
    }
  }
}
