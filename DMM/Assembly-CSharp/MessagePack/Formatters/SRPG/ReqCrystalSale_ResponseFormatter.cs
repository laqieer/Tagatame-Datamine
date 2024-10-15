// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCrystalSale_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008E6")]
  public sealed class ReqCrystalSale_ResponseFormatter : 
    IMessagePackFormatter<ReqCrystalSale.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400165C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400165D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002400")]
    [Address(RVA = "0xDD7C70", Offset = "0xDD6A70", VA = "0x10DD7C70")]
    public ReqCrystalSale_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002401")]
    [Address(RVA = "0xDD7AA0", Offset = "0xDD68A0", VA = "0x10DD7AA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCrystalSale.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002402")]
    [Address(RVA = "0xDD76F0", Offset = "0xDD64F0", VA = "0x10DD76F0", Slot = "5")]
    public ReqCrystalSale.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCrystalSale.Response) null;
    }
  }
}
