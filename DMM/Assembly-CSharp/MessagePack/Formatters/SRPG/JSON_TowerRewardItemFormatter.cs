﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TowerRewardItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200059A")]
  public sealed class JSON_TowerRewardItemFormatter : 
    IMessagePackFormatter<JSON_TowerRewardItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FCC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FCD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A1C")]
    [Address(RVA = "0x793520", Offset = "0x792320", VA = "0x10793520")]
    public JSON_TowerRewardItemFormatter()
    {
    }

    [Token(Token = "0x6001A1D")]
    [Address(RVA = "0x793370", Offset = "0x792170", VA = "0x10793370", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TowerRewardItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A1E")]
    [Address(RVA = "0x793000", Offset = "0x791E00", VA = "0x10793000", Slot = "5")]
    public JSON_TowerRewardItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TowerRewardItem) null;
    }
  }
}