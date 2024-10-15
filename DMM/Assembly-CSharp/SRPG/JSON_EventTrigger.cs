// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_EventTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EBD")]
  [Serializable]
  public class JSON_EventTrigger
  {
    [Token(Token = "0x4002D6D")]
    [FieldOffset(Offset = "0x8")]
    public int trg;
    [Token(Token = "0x4002D6E")]
    [FieldOffset(Offset = "0xC")]
    public int type;
    [Token(Token = "0x4002D6F")]
    [FieldOffset(Offset = "0x10")]
    public int detail;
    [Token(Token = "0x4002D70")]
    [FieldOffset(Offset = "0x14")]
    public string val;
    [Token(Token = "0x4002D71")]
    [FieldOffset(Offset = "0x18")]
    public string sval;
    [Token(Token = "0x4002D72")]
    [FieldOffset(Offset = "0x1C")]
    public int ival;
    [Token(Token = "0x4002D73")]
    [FieldOffset(Offset = "0x20")]
    public int cnt;
    [Token(Token = "0x4002D74")]
    [FieldOffset(Offset = "0x24")]
    public string tag;

    [Token(Token = "0x6003D3A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_EventTrigger()
    {
    }
  }
}
