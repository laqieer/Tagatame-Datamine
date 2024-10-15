// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RunePrideBonusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CF3")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RunePrideBonusData
  {
    [Token(Token = "0x400716F")]
    [FieldOffset(Offset = "0x8")]
    public string draw_name;
    [Token(Token = "0x4007170")]
    [FieldOffset(Offset = "0xC")]
    public int type;
    [Token(Token = "0x4007171")]
    [FieldOffset(Offset = "0x10")]
    public int ex_type;
    [Token(Token = "0x4007172")]
    [FieldOffset(Offset = "0x14")]
    public int calc_type;
    [Token(Token = "0x4007173")]
    [FieldOffset(Offset = "0x18")]
    public int value;
    [Token(Token = "0x4007174")]
    [FieldOffset(Offset = "0x1C")]
    public string tag;

    [Token(Token = "0x60076E2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RunePrideBonusData()
    {
    }
  }
}
