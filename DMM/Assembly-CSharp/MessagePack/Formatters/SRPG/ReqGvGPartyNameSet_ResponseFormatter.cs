// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGPartyNameSet_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008B3")]
  public sealed class ReqGvGPartyNameSet_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGPartyNameSet.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015F6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015F7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002367")]
    [Address(RVA = "0xDC5840", Offset = "0xDC4640", VA = "0x10DC5840")]
    public ReqGvGPartyNameSet_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002368")]
    [Address(RVA = "0xDC57D0", Offset = "0xDC45D0", VA = "0x10DC57D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGPartyNameSet.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002369")]
    [Address(RVA = "0xDC5560", Offset = "0xDC4360", VA = "0x10DC5560", Slot = "5")]
    public ReqGvGPartyNameSet.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGPartyNameSet.Response) null;
    }
  }
}
