// Decompiled with JetBrains decompiler
// Type: SRPG.GimmickEventCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C0F")]
  public class GimmickEventCondition
  {
    [Token(Token = "0x4001F32")]
    [FieldOffset(Offset = "0x8")]
    public GimmickEventTriggerType type;
    [Token(Token = "0x4001F33")]
    [FieldOffset(Offset = "0xC")]
    public List<Unit> units;
    [Token(Token = "0x4001F34")]
    [FieldOffset(Offset = "0x10")]
    public List<Unit> targets;
    [Token(Token = "0x4001F35")]
    [FieldOffset(Offset = "0x14")]
    public List<TrickData> td_targets;
    [Token(Token = "0x4001F36")]
    [FieldOffset(Offset = "0x18")]
    public string td_iname;
    [Token(Token = "0x4001F37")]
    [FieldOffset(Offset = "0x1C")]
    public string td_tag;
    [Token(Token = "0x4001F38")]
    [FieldOffset(Offset = "0x20")]
    public List<Grid> grids;
    [Token(Token = "0x4001F39")]
    [FieldOffset(Offset = "0x24")]
    public int count;

    [Token(Token = "0x6003020")]
    [Address(RVA = "0xFE43B0", Offset = "0xFE31B0", VA = "0x10FE43B0")]
    public GimmickEventCondition()
    {
    }
  }
}
