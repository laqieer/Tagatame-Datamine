// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqConceptSetOverWriteList_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A3D")]
  public sealed class ReqConceptSetOverWriteList_ResponseFormatter : 
    IMessagePackFormatter<ReqConceptSetOverWriteList.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400190A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400190B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002805")]
    [Address(RVA = "0xEB5330", Offset = "0xEB4130", VA = "0x10EB5330")]
    public ReqConceptSetOverWriteList_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002806")]
    [Address(RVA = "0xEB5230", Offset = "0xEB4030", VA = "0x10EB5230", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqConceptSetOverWriteList.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002807")]
    [Address(RVA = "0xEB4F60", Offset = "0xEB3D60", VA = "0x10EB4F60", Slot = "5")]
    public ReqConceptSetOverWriteList.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqConceptSetOverWriteList.Response) null;
    }
  }
}
