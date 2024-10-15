// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RankingQuestRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C8E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RankingQuestRewardParam
  {
    [Token(Token = "0x400702D")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400702E")]
    [FieldOffset(Offset = "0xC")]
    public string type;
    [Token(Token = "0x400702F")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x4007030")]
    [FieldOffset(Offset = "0x14")]
    public int num;

    [Token(Token = "0x60075AF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RankingQuestRewardParam()
    {
    }
  }
}
