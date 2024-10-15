// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TokkouParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200076C")]
  public sealed class TokkouParamFormatter : 
    IMessagePackFormatter<TokkouParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001370")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001371")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F92")]
    [Address(RVA = "0xCB9680", Offset = "0xCB8480", VA = "0x10CB9680")]
    public TokkouParamFormatter()
    {
    }

    [Token(Token = "0x6001F93")]
    [Address(RVA = "0xCB94E0", Offset = "0xCB82E0", VA = "0x10CB94E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TokkouParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F94")]
    [Address(RVA = "0xCB91E0", Offset = "0xCB7FE0", VA = "0x10CB91E0", Slot = "5")]
    public TokkouParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TokkouParam) null;
    }
  }
}
