// Decompiled with JetBrains decompiler
// Type: SRPG.Json_Artifact
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E58")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_Artifact
  {
    [Token(Token = "0x4002BB9")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4002BBA")]
    [FieldOffset(Offset = "0x10")]
    public long iid;
    [Token(Token = "0x4002BBB")]
    [FieldOffset(Offset = "0x18")]
    public int rare;
    [Token(Token = "0x4002BBC")]
    [FieldOffset(Offset = "0x1C")]
    public int exp;
    [Token(Token = "0x4002BBD")]
    [FieldOffset(Offset = "0x20")]
    public int fav;
    [Token(Token = "0x4002BBE")]
    [FieldOffset(Offset = "0x24")]
    public int inspiration_skill_slots;
    [Token(Token = "0x4002BBF")]
    [FieldOffset(Offset = "0x28")]
    public Json_InspirationSkill[] inspiration_skills;
    [Token(Token = "0x4002BC0")]
    [FieldOffset(Offset = "0x2C")]
    public int is_stone_open;
    [Token(Token = "0x4002BC1")]
    [FieldOffset(Offset = "0x30")]
    public string stone_iname;

    [Token(Token = "0x6003B14")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_Artifact()
    {
    }
  }
}
