// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqRuneEquip_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200098A")]
  public sealed class ReqRuneEquip_RequestParamFormatter : 
    IMessagePackFormatter<ReqRuneEquip.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017A4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017A5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025EC")]
    [Address(RVA = "0xE45700", Offset = "0xE44500", VA = "0x10E45700")]
    public ReqRuneEquip_RequestParamFormatter()
    {
    }

    [Token(Token = "0x60025ED")]
    [Address(RVA = "0xE455D0", Offset = "0xE443D0", VA = "0x10E455D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqRuneEquip.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025EE")]
    [Address(RVA = "0xE452A0", Offset = "0xE440A0", VA = "0x10E452A0", Slot = "5")]
    public ReqRuneEquip.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqRuneEquip.RequestParam) null;
    }
  }
}
