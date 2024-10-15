// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusCoin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EB0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusCoin
  {
    [Token(Token = "0x4008089")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400808A")]
    [FieldOffset(Offset = "0xC")]
    public string coin_iname;
    [Token(Token = "0x400808B")]
    [FieldOffset(Offset = "0x10")]
    public int win_cnt;
    [Token(Token = "0x400808C")]
    [FieldOffset(Offset = "0x14")]
    public int lose_cnt;
    [Token(Token = "0x400808D")]
    [FieldOffset(Offset = "0x18")]
    public int draw_cnt;

    [Token(Token = "0x6007DC9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusCoin()
    {
    }
  }
}
