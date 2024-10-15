// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MapParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BD7")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_MapParam
  {
    [Token(Token = "0x4006ACB")]
    [FieldOffset(Offset = "0x8")]
    public string scn;
    [Token(Token = "0x4006ACC")]
    [FieldOffset(Offset = "0xC")]
    public string set;
    [Token(Token = "0x4006ACD")]
    [FieldOffset(Offset = "0x10")]
    public string btl;
    [Token(Token = "0x4006ACE")]
    [FieldOffset(Offset = "0x14")]
    public string bgm;
    [Token(Token = "0x4006ACF")]
    [FieldOffset(Offset = "0x18")]
    public string ev;

    [Token(Token = "0x60072F9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MapParam()
    {
    }
  }
}
