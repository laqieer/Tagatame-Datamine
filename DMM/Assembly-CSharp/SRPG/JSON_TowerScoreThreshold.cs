// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TowerScoreThreshold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D7F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TowerScoreThreshold
  {
    [Token(Token = "0x400748F")]
    [FieldOffset(Offset = "0x8")]
    public int score;
    [Token(Token = "0x4007490")]
    [FieldOffset(Offset = "0xC")]
    public string rank;
    [Token(Token = "0x4007491")]
    [FieldOffset(Offset = "0x10")]
    public int turn;
    [Token(Token = "0x4007492")]
    [FieldOffset(Offset = "0x14")]
    public int died;
    [Token(Token = "0x4007493")]
    [FieldOffset(Offset = "0x18")]
    public int retire;
    [Token(Token = "0x4007494")]
    [FieldOffset(Offset = "0x1C")]
    public int recover;

    [Token(Token = "0x60078A5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TowerScoreThreshold()
    {
    }
  }
}
