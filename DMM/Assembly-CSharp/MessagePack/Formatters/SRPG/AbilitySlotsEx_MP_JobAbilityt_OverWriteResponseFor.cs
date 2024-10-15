// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AbilitySlotsEx_MP_JobAbilityt_OverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200088C")]
  public sealed class AbilitySlotsEx_MP_JobAbilityt_OverWriteResponseFormatter : 
    IMessagePackFormatter<AbilitySlotsEx.MP_JobAbilityt_OverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015A8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015A9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022F2")]
    [Address(RVA = "0xD984C0", Offset = "0xD972C0", VA = "0x10D984C0")]
    public AbilitySlotsEx_MP_JobAbilityt_OverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x60022F3")]
    [Address(RVA = "0xD981D0", Offset = "0xD96FD0", VA = "0x10D981D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AbilitySlotsEx.MP_JobAbilityt_OverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022F4")]
    [Address(RVA = "0xD97DA0", Offset = "0xD96BA0", VA = "0x10D97DA0", Slot = "5")]
    public AbilitySlotsEx.MP_JobAbilityt_OverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (AbilitySlotsEx.MP_JobAbilityt_OverWriteResponse) null;
    }
  }
}
