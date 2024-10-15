// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqUnitJob_OverWrite_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A28")]
  public sealed class ReqUnitJob_OverWrite_ResponseFormatter : 
    IMessagePackFormatter<ReqUnitJob_OverWrite.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018E0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018E1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027C6")]
    [Address(RVA = "0xEA73D0", Offset = "0xEA61D0", VA = "0x10EA73D0")]
    public ReqUnitJob_OverWrite_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027C7")]
    [Address(RVA = "0xEA71F0", Offset = "0xEA5FF0", VA = "0x10EA71F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqUnitJob_OverWrite.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027C8")]
    [Address(RVA = "0xEA6EB0", Offset = "0xEA5CB0", VA = "0x10EA6EB0", Slot = "5")]
    public ReqUnitJob_OverWrite.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqUnitJob_OverWrite.Response) null;
    }
  }
}
