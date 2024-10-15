// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqStatusAwakeGetUseItem_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AFE")]
  public sealed class ReqStatusAwakeGetUseItem_ResponseFormatter : 
    IMessagePackFormatter<ReqStatusAwakeGetUseItem.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A8C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A8D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A48")]
    [Address(RVA = "0xF2B230", Offset = "0xF2A030", VA = "0x10F2B230")]
    public ReqStatusAwakeGetUseItem_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A49")]
    [Address(RVA = "0xF2B130", Offset = "0xF29F30", VA = "0x10F2B130", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqStatusAwakeGetUseItem.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A4A")]
    [Address(RVA = "0xF2AE60", Offset = "0xF29C60", VA = "0x10F2AE60", Slot = "5")]
    public ReqStatusAwakeGetUseItem.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqStatusAwakeGetUseItem.Response) null;
    }
  }
}
