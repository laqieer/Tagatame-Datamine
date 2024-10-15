// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_InfinitySpawnGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C03")]
  [Serializable]
  public class JSON_InfinitySpawnGroup
  {
    [Token(Token = "0x4001EB7")]
    [FieldOffset(Offset = "0x8")]
    public int tag;
    [Token(Token = "0x4001EB8")]
    [FieldOffset(Offset = "0xC")]
    public int deck;
    [Token(Token = "0x4001EB9")]
    [FieldOffset(Offset = "0x10")]
    public int interval;
    [Token(Token = "0x4001EBA")]
    [FieldOffset(Offset = "0x14")]
    public int spawn_max;
    [Token(Token = "0x4001EBB")]
    [FieldOffset(Offset = "0x18")]
    public int spawn_unit_num;
    [Token(Token = "0x4001EBC")]
    [FieldOffset(Offset = "0x1C")]
    public int is_spawn_at_start;
    [Token(Token = "0x4001EBD")]
    [FieldOffset(Offset = "0x20")]
    public int is_skip_empty_at_start;

    [Token(Token = "0x6003010")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_InfinitySpawnGroup()
    {
    }
  }
}
