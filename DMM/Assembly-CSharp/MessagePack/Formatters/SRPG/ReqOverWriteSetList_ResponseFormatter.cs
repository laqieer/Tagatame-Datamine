// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqOverWriteSetList_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A41")]
  public sealed class ReqOverWriteSetList_ResponseFormatter : 
    IMessagePackFormatter<ReqOverWriteSetList.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001912")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001913")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002811")]
    [Address(RVA = "0xEBC7E0", Offset = "0xEBB5E0", VA = "0x10EBC7E0")]
    public ReqOverWriteSetList_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002812")]
    [Address(RVA = "0xEBC6E0", Offset = "0xEBB4E0", VA = "0x10EBC6E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqOverWriteSetList.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002813")]
    [Address(RVA = "0xEBC410", Offset = "0xEBB210", VA = "0x10EBC410", Slot = "5")]
    public ReqOverWriteSetList.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqOverWriteSetList.Response) null;
    }
  }
}
