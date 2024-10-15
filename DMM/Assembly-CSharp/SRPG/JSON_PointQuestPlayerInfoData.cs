// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PointQuestPlayerInfoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002818")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_PointQuestPlayerInfoData
  {
    [Token(Token = "0x400BF0F")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x400BF10")]
    [FieldOffset(Offset = "0xC")]
    public int lv;
    [Token(Token = "0x400BF11")]
    [FieldOffset(Offset = "0x10")]
    public Json_Unit unit;
    [Token(Token = "0x400BF12")]
    [FieldOffset(Offset = "0x14")]
    public JSON_PointQuestGuildData guild;
    [Token(Token = "0x400BF13")]
    [FieldOffset(Offset = "0x18")]
    public int total_point;
    [Token(Token = "0x400BF14")]
    [FieldOffset(Offset = "0x1C")]
    public int rank;

    [Token(Token = "0x600B50F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PointQuestPlayerInfoData()
    {
    }
  }
}
