// Decompiled with JetBrains decompiler
// Type: SRPG.InvalidSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FD2")]
  [MessagePackObject(true)]
  [SerializeField]
  public class InvalidSkill
  {
    [Token(Token = "0x40037E0")]
    [FieldOffset(Offset = "0x8")]
    public long mJobIid;
    [Token(Token = "0x40037E1")]
    [FieldOffset(Offset = "0x10")]
    public EInvalidSkillApplyType mApplyType;
    [Token(Token = "0x40037E2")]
    [FieldOffset(Offset = "0x14")]
    public string mSkilIname;
    [Token(Token = "0x40037E3")]
    [FieldOffset(Offset = "0x18")]
    public EInvalidSkillType mItemType;

    [Token(Token = "0x60041C2")]
    [Address(RVA = "0x1197E60", Offset = "0x1196C60", VA = "0x11197E60")]
    public InvalidSkill()
    {
    }
  }
}
