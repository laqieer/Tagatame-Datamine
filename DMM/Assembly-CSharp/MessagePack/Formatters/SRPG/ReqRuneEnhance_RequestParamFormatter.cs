// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneEnhance_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200098F")]
  public sealed class ReqRuneEnhance_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneEnhance.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017AE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017AF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025FB")]
    [Address(RVA = "0xE43AF0", Offset = "0xE428F0", VA = "0x10E43AF0")]
    public ReqRuneEnhance_RequestParamFormatter()
    {
    }

    [Token(Token = "0x60025FC")]
    [Address(RVA = "0xE439F0", Offset = "0xE427F0", VA = "0x10E439F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneEnhance.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025FD")]
    [Address(RVA = "0xE436F0", Offset = "0xE424F0", VA = "0x10E436F0", Slot = "5")]
    public ReqRuneEnhance.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneEnhance.RequestParam) null;
    }
  }
}
