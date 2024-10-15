// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneResetDedicated_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200099F")]
  public sealed class ReqRuneResetDedicated_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneResetDedicated.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017CE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017CF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600262B")]
    [Address(RVA = "0xE48200", Offset = "0xE47000", VA = "0x10E48200")]
    public ReqRuneResetDedicated_RequestParamFormatter()
    {
    }

    [Token(Token = "0x600262C")]
    [Address(RVA = "0xE48140", Offset = "0xE46F40", VA = "0x10E48140", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneResetDedicated.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600262D")]
    [Address(RVA = "0xE47E80", Offset = "0xE46C80", VA = "0x10E47E80", Slot = "5")]
    public ReqRuneResetDedicated.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneResetDedicated.RequestParam) null;
    }
  }
}
