// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqStatusAwake_StatusAwakeResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AFD")]
  public sealed class ReqStatusAwake_StatusAwakeResponseFormatter : 
    IMessagePackFormatter<ReqStatusAwake.StatusAwakeResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A8A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A8B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A45")]
    [Address(RVA = "0xF2DB50", Offset = "0xF2C950", VA = "0x10F2DB50")]
    public ReqStatusAwake_StatusAwakeResponseFormatter()
    {
    }

    [Token(Token = "0x6002A46")]
    [Address(RVA = "0xF2D860", Offset = "0xF2C660", VA = "0x10F2D860", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqStatusAwake.StatusAwakeResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A47")]
    [Address(RVA = "0xF2D430", Offset = "0xF2C230", VA = "0x10F2D430", Slot = "5")]
    public ReqStatusAwake.StatusAwakeResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqStatusAwake.StatusAwakeResponse) null;
    }
  }
}
