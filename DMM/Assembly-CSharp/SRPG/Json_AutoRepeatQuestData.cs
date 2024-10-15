// Decompiled with JetBrains decompiler
// Type: SRPG.Json_AutoRepeatQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001994")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_AutoRepeatQuestData
  {
    [Token(Token = "0x4005DA6")]
    [FieldOffset(Offset = "0x8")]
    public string qid;
    [Token(Token = "0x4005DA7")]
    [FieldOffset(Offset = "0xC")]
    public long[] units;
    [Token(Token = "0x4005DA8")]
    [FieldOffset(Offset = "0x10")]
    public string start_time;
    [Token(Token = "0x4005DA9")]
    [FieldOffset(Offset = "0x14")]
    public int time_per_lap;
    [Token(Token = "0x4005DAA")]
    [FieldOffset(Offset = "0x18")]
    public int lap_num;
    [Token(Token = "0x4005DAB")]
    [FieldOffset(Offset = "0x1C")]
    public int lap_num_not_box;
    [Token(Token = "0x4005DAC")]
    [FieldOffset(Offset = "0x20")]
    public int is_full_box;
    [Token(Token = "0x4005DAD")]
    [FieldOffset(Offset = "0x24")]
    public int stop_reason;
    [Token(Token = "0x4005DAE")]
    [FieldOffset(Offset = "0x28")]
    public int current_lap_num;
    [Token(Token = "0x4005DAF")]
    [FieldOffset(Offset = "0x2C")]
    public int gold;
    [Token(Token = "0x4005DB0")]
    [FieldOffset(Offset = "0x30")]
    public BattleCore.Json_BtlDrop[][] drops;
    [Token(Token = "0x4005DB1")]
    [FieldOffset(Offset = "0x34")]
    public int auto_repeat_check;

    [Token(Token = "0x600684A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_AutoRepeatQuestData()
    {
    }
  }
}
