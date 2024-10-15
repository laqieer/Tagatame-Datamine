// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqConceptSetOverWriteList_ReqConceptSetOverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A3E")]
  public sealed class ReqConceptSetOverWriteList_ReqConceptSetOverWriteResponseFormatter : 
    IMessagePackFormatter<ReqConceptSetOverWriteList.ReqConceptSetOverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400190C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400190D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002808")]
    [Address(RVA = "0xEB4650", Offset = "0xEB3450", VA = "0x10EB4650")]
    public ReqConceptSetOverWriteList_ReqConceptSetOverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x6002809")]
    [Address(RVA = "0xEB4360", Offset = "0xEB3160", VA = "0x10EB4360", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqConceptSetOverWriteList.ReqConceptSetOverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600280A")]
    [Address(RVA = "0xEB3F30", Offset = "0xEB2D30", VA = "0x10EB3F30", Slot = "5")]
    public ReqConceptSetOverWriteList.ReqConceptSetOverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqConceptSetOverWriteList.ReqConceptSetOverWriteResponse) null;
    }
  }
}
