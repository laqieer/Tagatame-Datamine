// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqMultiSupportList_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008D4")]
  public sealed class ReqMultiSupportList_ResponseFormatter : 
    IMessagePackFormatter<ReqMultiSupportList.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001638")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001639")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023CA")]
    [Address(RVA = "0xDDA170", Offset = "0xDD8F70", VA = "0x10DDA170")]
    public ReqMultiSupportList_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023CB")]
    [Address(RVA = "0xDDA000", Offset = "0xDD8E00", VA = "0x10DDA000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqMultiSupportList.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023CC")]
    [Address(RVA = "0xDD9D30", Offset = "0xDD8B30", VA = "0x10DD9D30", Slot = "5")]
    public ReqMultiSupportList.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqMultiSupportList.Response) null;
    }
  }
}
