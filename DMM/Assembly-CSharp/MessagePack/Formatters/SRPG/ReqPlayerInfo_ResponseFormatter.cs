// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqPlayerInfo_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000709")]
  public sealed class ReqPlayerInfo_ResponseFormatter : 
    IMessagePackFormatter<ReqPlayerInfo.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012AA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012AB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E69")]
    [Address(RVA = "0xC67490", Offset = "0xC66290", VA = "0x10C67490")]
    public ReqPlayerInfo_ResponseFormatter()
    {
    }

    [Token(Token = "0x6001E6A")]
    [Address(RVA = "0xC672E0", Offset = "0xC660E0", VA = "0x10C672E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqPlayerInfo.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E6B")]
    [Address(RVA = "0xC66F50", Offset = "0xC65D50", VA = "0x10C66F50", Slot = "5")]
    public ReqPlayerInfo.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqPlayerInfo.Response) null;
    }
  }
}
