// Decompiled with JetBrains decompiler
// Type: SRPG.Grid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C1F")]
  [MessagePackObject(true)]
  [Serializable]
  public class Grid
  {
    [Token(Token = "0x4001F79")]
    public const int DEFAULT_COST = 1;
    [Token(Token = "0x4001F7A")]
    [FieldOffset(Offset = "0x8")]
    public int x;
    [Token(Token = "0x4001F7B")]
    [FieldOffset(Offset = "0xC")]
    public int y;
    [Token(Token = "0x4001F7C")]
    [FieldOffset(Offset = "0x10")]
    public int height;
    [Token(Token = "0x4001F7D")]
    [FieldOffset(Offset = "0x14")]
    public int cost;
    [Token(Token = "0x4001F7E")]
    [FieldOffset(Offset = "0x18")]
    public byte step;
    [Token(Token = "0x4001F7F")]
    [FieldOffset(Offset = "0x1C")]
    public string tile;
    [Token(Token = "0x4001F80")]
    [FieldOffset(Offset = "0x20")]
    public GeoParam geo;
    [Token(Token = "0x4001F81")]
    [FieldOffset(Offset = "0x24")]
    public int enter;

    [Token(Token = "0x600302F")]
    [Address(RVA = "0xFE46C0", Offset = "0xFE34C0", VA = "0x10FE46C0")]
    public bool IsDisableStopped() => new bool();

    [Token(Token = "0x6003030")]
    [Address(RVA = "0xFE4700", Offset = "0xFE3500", VA = "0x10FE4700")]
    public bool IsEnter(eMovType mov_type) => new bool();

    [Token(Token = "0x6003031")]
    [Address(RVA = "0xFE4720", Offset = "0xFE3520", VA = "0x10FE4720")]
    public Grid()
    {
    }
  }
}
