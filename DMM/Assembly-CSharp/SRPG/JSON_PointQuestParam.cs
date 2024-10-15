// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PointQuestParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C0D")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_PointQuestParam
  {
    [Token(Token = "0x4006CAE")]
    [FieldOffset(Offset = "0x8")]
    public string quest_iname;
    [Token(Token = "0x4006CAF")]
    [FieldOffset(Offset = "0xC")]
    public int skip_rate;
    [Token(Token = "0x4006CB0")]
    [FieldOffset(Offset = "0x10")]
    public JSON_PointQuestVariables[] variables;
    [Token(Token = "0x4006CB1")]
    [FieldOffset(Offset = "0x14")]
    public string mission_iname;
    [Token(Token = "0x4006CB2")]
    [FieldOffset(Offset = "0x18")]
    public int action_num_method;
    [Token(Token = "0x4006CB3")]
    [FieldOffset(Offset = "0x1C")]
    public string unit;

    [Token(Token = "0x600738E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PointQuestParam()
    {
    }
  }
}
