// Decompiled with JetBrains decompiler
// Type: SRPG.AIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DD0")]
  [MessagePackObject(true)]
  public class AIParam
  {
    [Token(Token = "0x4007713")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007714")]
    [FieldOffset(Offset = "0xC")]
    public RoleTypes role;
    [Token(Token = "0x4007715")]
    [FieldOffset(Offset = "0x10")]
    public ParamTypes param;
    [Token(Token = "0x4007716")]
    [FieldOffset(Offset = "0x14")]
    public ParamPriorities param_prio;
    [Token(Token = "0x4007717")]
    [FieldOffset(Offset = "0x18")]
    public OLong flags;
    [Token(Token = "0x4007718")]
    [FieldOffset(Offset = "0x40")]
    public OInt escape_border;
    [Token(Token = "0x4007719")]
    [FieldOffset(Offset = "0x54")]
    public OInt heal_border;
    [Token(Token = "0x400771A")]
    [FieldOffset(Offset = "0x68")]
    public OInt gems_border;
    [Token(Token = "0x400771B")]
    [FieldOffset(Offset = "0x7C")]
    public OInt buff_border;
    [Token(Token = "0x400771C")]
    [FieldOffset(Offset = "0x90")]
    public OInt cond_border;
    [Token(Token = "0x400771D")]
    [FieldOffset(Offset = "0xA4")]
    public OInt safe_border;
    [Token(Token = "0x400771E")]
    [FieldOffset(Offset = "0xB8")]
    public OInt gosa_border;
    [Token(Token = "0x400771F")]
    [FieldOffset(Offset = "0xCC")]
    public OInt DisableSupportActionHpBorder;
    [Token(Token = "0x4007720")]
    [FieldOffset(Offset = "0xE0")]
    public OInt DisableSupportActionMemberBorder;
    [Token(Token = "0x4007721")]
    [FieldOffset(Offset = "0xF4")]
    public SkillCategory[] SkillCategoryPriorities;
    [Token(Token = "0x4007722")]
    [FieldOffset(Offset = "0xF8")]
    public ParamTypes[] BuffPriorities;
    [Token(Token = "0x4007723")]
    [FieldOffset(Offset = "0xFC")]
    public EUnitCondition[] ConditionPriorities;

    [Token(Token = "0x60079E1")]
    [Address(RVA = "0x3B1370", Offset = "0x3B0170", VA = "0x103B1370")]
    public bool Deserialize(JSON_AIParam json) => new bool();

    [Token(Token = "0x60079E2")]
    [Address(RVA = "0x3B1310", Offset = "0x3B0110", VA = "0x103B1310")]
    public bool CheckFlag(AIFlags flag) => new bool();

    [Token(Token = "0x60079E3")]
    [Address(RVA = "0x3B1AA0", Offset = "0x3B08A0", VA = "0x103B1AA0")]
    public AIParam()
    {
    }
  }
}
