// Decompiled with JetBrains decompiler
// Type: SRPG.InfinitySpawnGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001191")]
  public class InfinitySpawnGroupData
  {
    [Token(Token = "0x4003FB3")]
    [FieldOffset(Offset = "0x8")]
    public int tag;
    [Token(Token = "0x4003FB4")]
    [FieldOffset(Offset = "0xC")]
    public int deck;
    [Token(Token = "0x4003FB5")]
    [FieldOffset(Offset = "0x10")]
    public int interval;
    [Token(Token = "0x4003FB6")]
    [FieldOffset(Offset = "0x14")]
    public int spawn_max;
    [Token(Token = "0x4003FB7")]
    [FieldOffset(Offset = "0x18")]
    public int spawn_unit_num;
    [Token(Token = "0x4003FB8")]
    [FieldOffset(Offset = "0x1C")]
    public int is_spawn_at_start;
    [Token(Token = "0x4003FB9")]
    [FieldOffset(Offset = "0x20")]
    public int is_skip_empty_at_start;
    [Token(Token = "0x4003FBA")]
    [FieldOffset(Offset = "0x24")]
    private List<InfinitySpawnData> mInfinitySpawns;

    [Token(Token = "0x17000846")]
    public List<InfinitySpawnData> InfinitySpawns
    {
      [Token(Token = "0x6004B07"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<InfinitySpawnData>) null;
      }
    }

    [Token(Token = "0x6004B08")]
    [Address(RVA = "0x11FF910", Offset = "0x11FE710", VA = "0x111FF910")]
    public void Setup(JSON_InfinitySpawnGroup json_data)
    {
    }

    [Token(Token = "0x6004B09")]
    [Address(RVA = "0x11FF630", Offset = "0x11FE430", VA = "0x111FF630")]
    public void AddSameGroup(InfinitySpawnData[] spawns)
    {
    }

    [Token(Token = "0x6004B0A")]
    [Address(RVA = "0x11FF6E0", Offset = "0x11FE4E0", VA = "0x111FF6E0")]
    public int GetSpawnableCount(
      List<Unit> units,
      int reserved_count,
      int act_count,
      bool easy_check = false)
    {
      return new int();
    }

    [Token(Token = "0x6004B0B")]
    [Address(RVA = "0x11FF530", Offset = "0x11FE330", VA = "0x111FF530")]
    public void AddReserve(int deck_index)
    {
    }

    [Token(Token = "0x6004B0C")]
    [Address(RVA = "0x11FF860", Offset = "0x11FE660", VA = "0x111FF860")]
    public void Reset()
    {
    }

    [Token(Token = "0x6004B0D")]
    [Address(RVA = "0x11FF950", Offset = "0x11FE750", VA = "0x111FF950")]
    public InfinitySpawnGroupData()
    {
    }
  }
}
