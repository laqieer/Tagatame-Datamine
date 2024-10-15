// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRoleBonus_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009DB")]
  public sealed class ReqGuildRoleBonus_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRoleBonus.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001846")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001847")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026DF")]
    [Address(RVA = "0xE8D3B0", Offset = "0xE8C1B0", VA = "0x10E8D3B0")]
    public ReqGuildRoleBonus_ResponseFormatter()
    {
    }

    [Token(Token = "0x60026E0")]
    [Address(RVA = "0xE8D010", Offset = "0xE8BE10", VA = "0x10E8D010", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRoleBonus.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026E1")]
    [Address(RVA = "0xE8CB30", Offset = "0xE8B930", VA = "0x10E8CB30", Slot = "5")]
    public ReqGuildRoleBonus.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRoleBonus.Response) null;
    }
  }
}
