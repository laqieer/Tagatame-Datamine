// Decompiled with JetBrains decompiler
// Type: SRPG.InfinitySpawnManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200118F")]
  public class InfinitySpawnManager
  {
    [Token(Token = "0x4003FAF")]
    [FieldOffset(Offset = "0x8")]
    private JSON_MapUnit mMapSet;
    [Token(Token = "0x4003FB0")]
    [FieldOffset(Offset = "0xC")]
    private InfinitySpawnGroupData[] mInfinitySpawnGroups;
    [Token(Token = "0x4003FB1")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, List<JSON_MapEnemyUnit>> mInfinitySpawnDeck;

    [Token(Token = "0x17000844")]
    public InfinitySpawnGroupData[] InfinitySpawnGroups
    {
      [Token(Token = "0x6004AFC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (InfinitySpawnGroupData[]) null;
      }
    }

    [Token(Token = "0x17000845")]
    public JSON_MapEnemyUnit[] Deck
    {
      [Token(Token = "0x6004AFD"), Address(RVA = "0xAC6CA0", Offset = "0xAC5AA0", VA = "0x10AC6CA0")] get
      {
        return (JSON_MapEnemyUnit[]) null;
      }
    }

    [Token(Token = "0x6004AFE")]
    [Address(RVA = "0x11FFAC0", Offset = "0x11FE8C0", VA = "0x111FFAC0")]
    public void Init(JSON_MapUnit mapset)
    {
    }

    [Token(Token = "0x6004AFF")]
    [Address(RVA = "0x1200420", Offset = "0x11FF220", VA = "0x11200420")]
    public void RefreshSpawnEnemyUnits(List<Unit> units)
    {
    }

    [Token(Token = "0x6004B00")]
    [Address(RVA = "0x1200290", Offset = "0x11FF090", VA = "0x11200290")]
    public void RefreshSpawnEnemyUnitsForBattleStart(List<Unit> units)
    {
    }

    [Token(Token = "0x6004B01")]
    [Address(RVA = "0x1200050", Offset = "0x11FEE50", VA = "0x11200050")]
    private int Lot(List<JSON_MapEnemyUnit> deck, bool is_ignore_empty = false) => new int();

    [Token(Token = "0x6004B02")]
    [Address(RVA = "0x11FF9C0", Offset = "0x11FE7C0", VA = "0x111FF9C0")]
    public int GetDeckIndex(JSON_MapEnemyUnit unit) => new int();

    [Token(Token = "0x6004B03")]
    [Address(RVA = "0x11FFA80", Offset = "0x11FE880", VA = "0x111FFA80")]
    public JSON_MapEnemyUnit GetDeckUnit(int deck_index) => (JSON_MapEnemyUnit) null;

    [Token(Token = "0x6004B04")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public InfinitySpawnManager()
    {
    }
  }
}
