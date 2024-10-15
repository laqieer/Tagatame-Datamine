// Decompiled with JetBrains decompiler
// Type: SRPG.Json_Job
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200100B")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_Job
  {
    [Token(Token = "0x4003905")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x4003906")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x4003907")]
    [FieldOffset(Offset = "0x14")]
    public int rank;
    [Token(Token = "0x4003908")]
    [FieldOffset(Offset = "0x18")]
    public string cur_skin;
    [Token(Token = "0x4003909")]
    [FieldOffset(Offset = "0x1C")]
    public Json_Equip[] equips;
    [Token(Token = "0x400390A")]
    [FieldOffset(Offset = "0x20")]
    public Json_Ability[] abils;
    [Token(Token = "0x400390B")]
    [FieldOffset(Offset = "0x24")]
    public Json_Artifact[] artis;
    [Token(Token = "0x400390C")]
    [FieldOffset(Offset = "0x28")]
    public Json_JobSelectable select;
    [Token(Token = "0x400390D")]
    [FieldOffset(Offset = "0x2C")]
    public string unit_image;

    [Token(Token = "0x600426F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_Job()
    {
    }
  }
}
