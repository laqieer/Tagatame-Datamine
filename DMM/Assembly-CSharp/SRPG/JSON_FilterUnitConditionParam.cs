// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_FilterUnitConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D3D")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_FilterUnitConditionParam
  {
    [Token(Token = "0x40072D7")]
    [FieldOffset(Offset = "0x8")]
    public string cnds_iname;
    [Token(Token = "0x40072D8")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40072D9")]
    [FieldOffset(Offset = "0x10")]
    public int is_done;
    [Token(Token = "0x40072DA")]
    [FieldOffset(Offset = "0x14")]
    public int rarity_ini;
    [Token(Token = "0x40072DB")]
    [FieldOffset(Offset = "0x18")]
    public int birth;
    [Token(Token = "0x40072DC")]
    [FieldOffset(Offset = "0x1C")]
    public int sex;
    [Token(Token = "0x40072DD")]
    [FieldOffset(Offset = "0x20")]
    public string[] af_tags;
    [Token(Token = "0x40072DE")]
    [FieldOffset(Offset = "0x24")]
    public string[] un_groups;
    [Token(Token = "0x40072DF")]
    [FieldOffset(Offset = "0x28")]
    public string[] job_groups;

    [Token(Token = "0x60077E1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_FilterUnitConditionParam()
    {
    }
  }
}
