// Decompiled with JetBrains decompiler
// Type: SRPG.Json_PointQuestResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DAF")]
  public class Json_PointQuestResult
  {
    [Token(Token = "0x4002792")]
    [FieldOffset(Offset = "0x8")]
    public int win;
    [Token(Token = "0x4002793")]
    [FieldOffset(Offset = "0xC")]
    public Json_PointQuestMission[] missions;
    [Token(Token = "0x4002794")]
    [FieldOffset(Offset = "0x10")]
    public int sel_elem;
    [Token(Token = "0x4002795")]
    [FieldOffset(Offset = "0x14")]
    public int elem;
    [Token(Token = "0x4002796")]
    [FieldOffset(Offset = "0x18")]
    public int artifact;
    [Token(Token = "0x4002797")]
    [FieldOffset(Offset = "0x1C")]
    public int sex;
    [Token(Token = "0x4002798")]
    [FieldOffset(Offset = "0x20")]
    public int birth;
    [Token(Token = "0x4002799")]
    [FieldOffset(Offset = "0x24")]
    public int action_num;
    [Token(Token = "0x400279A")]
    [FieldOffset(Offset = "0x28")]
    public int dead_num;
    [Token(Token = "0x400279B")]
    [FieldOffset(Offset = "0x2C")]
    public int party_num;
    [Token(Token = "0x400279C")]
    [FieldOffset(Offset = "0x30")]
    public int unit_bonus;
    [Token(Token = "0x400279D")]
    [FieldOffset(Offset = "0x34")]
    public int concept_bonus;
    [Token(Token = "0x400279E")]
    [FieldOffset(Offset = "0x38")]
    public int this_time;
    [Token(Token = "0x400279F")]
    [FieldOffset(Offset = "0x3C")]
    public int best;
    [Token(Token = "0x40027A0")]
    [FieldOffset(Offset = "0x40")]
    public int total;
    [Token(Token = "0x40027A1")]
    [FieldOffset(Offset = "0x44")]
    public int total_before;
    [Token(Token = "0x40027A2")]
    [FieldOffset(Offset = "0x48")]
    public int event_best;
    [Token(Token = "0x40027A3")]
    [FieldOffset(Offset = "0x4C")]
    public int is_best_updated;
    [Token(Token = "0x40027A4")]
    [FieldOffset(Offset = "0x50")]
    public int is_event_best_updated;

    [Token(Token = "0x6003764")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_PointQuestResult()
    {
    }
  }
}
