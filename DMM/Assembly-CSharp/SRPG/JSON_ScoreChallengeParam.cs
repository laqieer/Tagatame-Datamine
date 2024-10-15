// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ScoreChallengeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C18")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ScoreChallengeParam
  {
    [Token(Token = "0x4006CD0")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006CD1")]
    [FieldOffset(Offset = "0xC")]
    public int is_valid;
    [Token(Token = "0x4006CD2")]
    [FieldOffset(Offset = "0x10")]
    public string exit_at;
    [Token(Token = "0x4006CD3")]
    [FieldOffset(Offset = "0x14")]
    public int is_port_top_ranking_hidden;

    [Token(Token = "0x60073BD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ScoreChallengeParam()
    {
    }
  }
}
