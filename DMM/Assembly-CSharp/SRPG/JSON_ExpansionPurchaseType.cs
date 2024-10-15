// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ExpansionPurchaseType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AD0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ExpansionPurchaseType
  {
    [Token(Token = "0x400637A")]
    [FieldOffset(Offset = "0x8")]
    public int type;
    [Token(Token = "0x400637B")]
    [FieldOffset(Offset = "0xC")]
    public int value;
    [Token(Token = "0x400637C")]
    [FieldOffset(Offset = "0x10")]
    public int quest_type;
    [Token(Token = "0x400637D")]
    [FieldOffset(Offset = "0x14")]
    public string quests_id;

    [Token(Token = "0x6006E79")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ExpansionPurchaseType()
    {
    }
  }
}
