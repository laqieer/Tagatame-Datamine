// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqJobAbility_OverWrite_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000724")]
  public sealed class ReqJobAbility_OverWrite_ResponseFormatter : 
    IMessagePackFormatter<ReqJobAbility_OverWrite.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012E0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012E1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EBA")]
    [Address(RVA = "0xC66DD0", Offset = "0xC65BD0", VA = "0x10C66DD0")]
    public ReqJobAbility_OverWrite_ResponseFormatter()
    {
    }

    [Token(Token = "0x6001EBB")]
    [Address(RVA = "0xC66BA0", Offset = "0xC659A0", VA = "0x10C66BA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqJobAbility_OverWrite.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EBC")]
    [Address(RVA = "0xC66860", Offset = "0xC65660", VA = "0x10C66860", Slot = "5")]
    public ReqJobAbility_OverWrite.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqJobAbility_OverWrite.Response) null;
    }
  }
}
