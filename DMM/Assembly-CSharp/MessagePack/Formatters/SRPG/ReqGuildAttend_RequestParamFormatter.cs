// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildAttend_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009D8")]
  public sealed class ReqGuildAttend_RequestParamFormatter : 
    IMessagePackFormatter<ReqGuildAttend.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001840")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001841")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026D6")]
    [Address(RVA = "0xE78050", Offset = "0xE76E50", VA = "0x10E78050")]
    public ReqGuildAttend_RequestParamFormatter()
    {
    }

    [Token(Token = "0x60026D7")]
    [Address(RVA = "0xE77F90", Offset = "0xE76D90", VA = "0x10E77F90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildAttend.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026D8")]
    [Address(RVA = "0xE77CD0", Offset = "0xE76AD0", VA = "0x10E77CD0", Slot = "5")]
    public ReqGuildAttend.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildAttend.RequestParam) null;
    }
  }
}
