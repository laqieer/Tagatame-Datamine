// Decompiled with JetBrains decompiler
// Type: SRPG.InfinitySpawnData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001192")]
  public class InfinitySpawnData
  {
    [Token(Token = "0x4003FBB")]
    [FieldOffset(Offset = "0x8")]
    public int x;
    [Token(Token = "0x4003FBC")]
    [FieldOffset(Offset = "0xC")]
    public int y;
    [Token(Token = "0x4003FBD")]
    [FieldOffset(Offset = "0x10")]
    public int group;
    [Token(Token = "0x4003FBE")]
    [FieldOffset(Offset = "0x14")]
    public int dir;
    [Token(Token = "0x4003FBF")]
    [FieldOffset(Offset = "0x18")]
    private List<int> mReserveUnitIndexList;

    [Token(Token = "0x17000847")]
    public List<int> ReserveUnitIndexList
    {
      [Token(Token = "0x6004B0F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x6004B10")]
    [Address(RVA = "0x11E92D0", Offset = "0x11E80D0", VA = "0x111E92D0")]
    public void Setup(JSON_InfinitySpawn json_data)
    {
    }

    [Token(Token = "0x6004B11")]
    [Address(RVA = "0x11FF430", Offset = "0x11FE230", VA = "0x111FF430")]
    public void AddReserveUnit(int deck_index)
    {
    }

    [Token(Token = "0x6004B12")]
    [Address(RVA = "0x11FF480", Offset = "0x11FE280", VA = "0x111FF480")]
    public void Reset()
    {
    }

    [Token(Token = "0x6004B13")]
    [Address(RVA = "0x11FF4C0", Offset = "0x11FE2C0", VA = "0x111FF4C0")]
    public InfinitySpawnData()
    {
    }
  }
}
