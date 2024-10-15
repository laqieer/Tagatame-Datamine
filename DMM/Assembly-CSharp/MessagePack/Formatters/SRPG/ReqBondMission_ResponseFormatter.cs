// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqBondMission_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000947")]
  public sealed class ReqBondMission_ResponseFormatter : 
    IMessagePackFormatter<ReqBondMission.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400171E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400171F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002523")]
    [Address(RVA = "0xE18F80", Offset = "0xE17D80", VA = "0x10E18F80")]
    public ReqBondMission_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002524")]
    [Address(RVA = "0xE18E10", Offset = "0xE17C10", VA = "0x10E18E10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqBondMission.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002525")]
    [Address(RVA = "0xE18B40", Offset = "0xE17940", VA = "0x10E18B40", Slot = "5")]
    public ReqBondMission.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqBondMission.Response) null;
    }
  }
}
