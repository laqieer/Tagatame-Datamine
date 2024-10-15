// Decompiled with JetBrains decompiler
// Type: SRPG.UnitMonitorCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C08")]
  [Serializable]
  public class UnitMonitorCondition
  {
    [Token(Token = "0x4001F03")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4001F04")]
    [FieldOffset(Offset = "0xC")]
    public string tag;
    [Token(Token = "0x4001F05")]
    [FieldOffset(Offset = "0x10")]
    public int turn;
    [Token(Token = "0x4001F06")]
    [FieldOffset(Offset = "0x14")]
    public int x;
    [Token(Token = "0x4001F07")]
    [FieldOffset(Offset = "0x18")]
    public int y;

    [Token(Token = "0x6003018")]
    [Address(RVA = "0xFEBA60", Offset = "0xFEA860", VA = "0x10FEBA60")]
    public UnitMonitorCondition()
    {
    }
  }
}
