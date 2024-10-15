// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGachaPickup_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A35")]
  public sealed class ReqGachaPickup_ResponseFormatter : 
    IMessagePackFormatter<ReqGachaPickup.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018FA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018FB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027ED")]
    [Address(RVA = "0xEB73F0", Offset = "0xEB61F0", VA = "0x10EB73F0")]
    public ReqGachaPickup_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027EE")]
    [Address(RVA = "0xEB7240", Offset = "0xEB6040", VA = "0x10EB7240", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGachaPickup.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027EF")]
    [Address(RVA = "0xEB6F30", Offset = "0xEB5D30", VA = "0x10EB6F30", Slot = "5")]
    public ReqGachaPickup.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGachaPickup.Response) null;
    }
  }
}
