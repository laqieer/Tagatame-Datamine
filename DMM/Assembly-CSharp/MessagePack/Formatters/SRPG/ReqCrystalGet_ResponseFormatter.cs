// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqCrystalGet_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A53")]
  public sealed class ReqCrystalGet_ResponseFormatter : 
    IMessagePackFormatter<ReqCrystalGet.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001936")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001937")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002847")]
    [Address(RVA = "0xED1C80", Offset = "0xED0A80", VA = "0x10ED1C80")]
    public ReqCrystalGet_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002848")]
    [Address(RVA = "0xED1B10", Offset = "0xED0910", VA = "0x10ED1B10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqCrystalGet.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002849")]
    [Address(RVA = "0xED1840", Offset = "0xED0640", VA = "0x10ED1840", Slot = "5")]
    public ReqCrystalGet.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqCrystalGet.Response) null;
    }
  }
}
