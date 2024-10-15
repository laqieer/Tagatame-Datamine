// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRoleBonus_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009DA")]
  public sealed class ReqGuildRoleBonus_RequestParamFormatter : 
    IMessagePackFormatter<ReqGuildRoleBonus.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001844")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001845")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026DC")]
    [Address(RVA = "0xE8CA10", Offset = "0xE8B810", VA = "0x10E8CA10")]
    public ReqGuildRoleBonus_RequestParamFormatter()
    {
    }

    [Token(Token = "0x60026DD")]
    [Address(RVA = "0xE8C950", Offset = "0xE8B750", VA = "0x10E8C950", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRoleBonus.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026DE")]
    [Address(RVA = "0xE8C690", Offset = "0xE8B490", VA = "0x10E8C690", Slot = "5")]
    public ReqGuildRoleBonus.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRoleBonus.RequestParam) null;
    }
  }
}
