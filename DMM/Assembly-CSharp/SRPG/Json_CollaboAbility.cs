// Decompiled with JetBrains decompiler
// Type: SRPG.Json_CollaboAbility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001008")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_CollaboAbility
  {
    [Token(Token = "0x40038FB")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x40038FC")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x40038FD")]
    [FieldOffset(Offset = "0x14")]
    public int exp;
    [Token(Token = "0x40038FE")]
    [FieldOffset(Offset = "0x18")]
    public Json_CollaboSkill[] skills;

    [Token(Token = "0x600426C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_CollaboAbility()
    {
    }
  }
}
