// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqConceptSetOverWriteList_RequestSetListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A3C")]
  public sealed class ReqConceptSetOverWriteList_RequestSetListFormatter : 
    IMessagePackFormatter<ReqConceptSetOverWriteList.RequestSetList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001908")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001909")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002802")]
    [Address(RVA = "0xEB4DE0", Offset = "0xEB3BE0", VA = "0x10EB4DE0")]
    public ReqConceptSetOverWriteList_RequestSetListFormatter()
    {
    }

    [Token(Token = "0x6002803")]
    [Address(RVA = "0xEB4CB0", Offset = "0xEB3AB0", VA = "0x10EB4CB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqConceptSetOverWriteList.RequestSetList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002804")]
    [Address(RVA = "0xEB4980", Offset = "0xEB3780", VA = "0x10EB4980", Slot = "5")]
    public ReqConceptSetOverWriteList.RequestSetList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqConceptSetOverWriteList.RequestSetList) null;
    }
  }
}
