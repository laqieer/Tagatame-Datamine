// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGvGNodeDeclare_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000978")]
  public sealed class ReqGvGNodeDeclare_ResponseFormatter : 
    IMessagePackFormatter<ReqGvGNodeDeclare.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001780")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001781")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025B6")]
    [Address(RVA = "0xE32B30", Offset = "0xE31930", VA = "0x10E32B30")]
    public ReqGvGNodeDeclare_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025B7")]
    [Address(RVA = "0xE328E0", Offset = "0xE316E0", VA = "0x10E328E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGvGNodeDeclare.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025B8")]
    [Address(RVA = "0xE32530", Offset = "0xE31330", VA = "0x10E32530", Slot = "5")]
    public ReqGvGNodeDeclare.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGvGNodeDeclare.Response) null;
    }
  }
}
