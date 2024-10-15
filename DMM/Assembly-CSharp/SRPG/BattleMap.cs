// Decompiled with JetBrains decompiler
// Type: SRPG.BattleMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C3B")]
  public class BattleMap
  {
    [Token(Token = "0x400201C")]
    public const int MOV_MAX = 99;
    [Token(Token = "0x400201D")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_GRID_WIDTH;
    [Token(Token = "0x400201E")]
    [FieldOffset(Offset = "0x4")]
    public static readonly int MAX_GRID_HEIGHT;
    [Token(Token = "0x400201F")]
    [FieldOffset(Offset = "0x8")]
    public static readonly int MAX_GRID_MOVING;
    [Token(Token = "0x4002020")]
    [FieldOffset(Offset = "0xC")]
    public static readonly int MAP_FLOOR_HEIGHT;
    [Token(Token = "0x4002021")]
    [FieldOffset(Offset = "0x8")]
    public string MapSceneName;
    [Token(Token = "0x4002022")]
    [FieldOffset(Offset = "0xC")]
    public string BattleSceneName;
    [Token(Token = "0x4002023")]
    [FieldOffset(Offset = "0x10")]
    public string EventSceneName;
    [Token(Token = "0x4002024")]
    [FieldOffset(Offset = "0x14")]
    public string BGMName;
    [Token(Token = "0x4002025")]
    [FieldOffset(Offset = "0x18")]
    private List<UnitSetting> mPartyUnitSettings;
    [Token(Token = "0x4002026")]
    [FieldOffset(Offset = "0x1C")]
    private List<UnitSubSetting> mPartyUnitSubSettings;
    [Token(Token = "0x4002027")]
    [FieldOffset(Offset = "0x20")]
    private List<NPCSetting> mNPCUnitSettings;
    [Token(Token = "0x4002028")]
    [FieldOffset(Offset = "0x24")]
    private List<UnitSetting> mArenaUnitSettings;
    [Token(Token = "0x4002029")]
    [FieldOffset(Offset = "0x28")]
    private QuestMonitorCondition mWinMonitorCondition;
    [Token(Token = "0x400202A")]
    [FieldOffset(Offset = "0x2C")]
    private QuestMonitorCondition mLoseMonitorCondition;
    [Token(Token = "0x400202B")]
    [FieldOffset(Offset = "0x30")]
    private List<JSON_GimmickEvent> mGimmickEvents;
    [Token(Token = "0x400202C")]
    [FieldOffset(Offset = "0x34")]
    private List<TrickSetting> mTrickSettings;
    [Token(Token = "0x400202D")]
    [FieldOffset(Offset = "0x38")]
    private InfinitySpawnManager mInfinitySpawnMgr;
    [Token(Token = "0x400202E")]
    [FieldOffset(Offset = "0x3C")]
    private BattleCore mBattle;
    [Token(Token = "0x400202F")]
    [FieldOffset(Offset = "0x40")]
    private int mWidth;
    [Token(Token = "0x4002030")]
    [FieldOffset(Offset = "0x44")]
    private int mHeight;
    [Token(Token = "0x4002031")]
    [FieldOffset(Offset = "0x48")]
    private Grid[,] mGrid;
    [Token(Token = "0x4002032")]
    [FieldOffset(Offset = "0x4C")]
    private BattleMapRoot mRoot;
    [Token(Token = "0x4002033")]
    [FieldOffset(Offset = "0x50")]
    private List<Grid> mMoveRoutes;
    [Token(Token = "0x4002034")]
    [FieldOffset(Offset = "0x54")]
    private int mMoveStep;
    [Token(Token = "0x4002035")]
    [FieldOffset(Offset = "0x58")]
    private Grid[] mCheckGrids;
    [Token(Token = "0x4002036")]
    [FieldOffset(Offset = "0x5C")]
    public RandDeckResult[] mRandDeckResult;
    [Token(Token = "0x4002037")]
    [FieldOffset(Offset = "0x10")]
    private static int[] ADJ_OFFSETS;

    [Token(Token = "0x170002D6")]
    public List<UnitSetting> PartyUnitSettings
    {
      [Token(Token = "0x6003057"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<UnitSetting>) null;
      }
    }

    [Token(Token = "0x170002D7")]
    public List<UnitSubSetting> PartyUnitSubSettings
    {
      [Token(Token = "0x6003058"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<UnitSubSetting>) null;
      }
    }

    [Token(Token = "0x170002D8")]
    public List<NPCSetting> NPCUnitSettings
    {
      [Token(Token = "0x6003059"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<NPCSetting>) null;
      }
    }

    [Token(Token = "0x170002D9")]
    public List<UnitSetting> ArenaUnitSettings
    {
      [Token(Token = "0x600305A"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<UnitSetting>) null;
      }
    }

    [Token(Token = "0x170002DA")]
    public QuestMonitorCondition WinMonitorCondition
    {
      [Token(Token = "0x600305B"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (QuestMonitorCondition) null;
      }
    }

    [Token(Token = "0x170002DB")]
    public QuestMonitorCondition LoseMonitorCondition
    {
      [Token(Token = "0x600305C"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (QuestMonitorCondition) null;
      }
    }

    [Token(Token = "0x170002DC")]
    public List<JSON_GimmickEvent> GimmickEvents
    {
      [Token(Token = "0x600305D"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (List<JSON_GimmickEvent>) null;
      }
    }

    [Token(Token = "0x170002DD")]
    public List<TrickSetting> TrickSettings
    {
      [Token(Token = "0x600305E"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (List<TrickSetting>) null;
      }
    }

    [Token(Token = "0x170002DE")]
    public InfinitySpawnManager InfinitySpawnMgr
    {
      [Token(Token = "0x600305F"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (InfinitySpawnManager) null;
      }
    }

    [Token(Token = "0x170002DF")]
    public int Width
    {
      [Token(Token = "0x6003060"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002E0")]
    public int Height
    {
      [Token(Token = "0x6003061"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002E1")]
    public int GridCount
    {
      [Token(Token = "0x6003062"), Address(RVA = "0xFDBF60", Offset = "0xFDAD60", VA = "0x10FDBF60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002E2")]
    public Grid this[int x, int y]
    {
      [Token(Token = "0x6003063"), Address(RVA = "0xFDBF70", Offset = "0xFDAD70", VA = "0x10FDBF70")] get
      {
        return (Grid) null;
      }
    }

    [Token(Token = "0x170002E3")]
    public Grid this[int i]
    {
      [Token(Token = "0x6003064"), Address(RVA = "0xFDBFB0", Offset = "0xFDADB0", VA = "0x10FDBFB0")] get
      {
        return (Grid) null;
      }
    }

    [Token(Token = "0x6003065")]
    [Address(RVA = "0xFDAC50", Offset = "0xFD9A50", VA = "0x10FDAC50")]
    public bool Initialize(BattleCore core, MapParam param) => new bool();

    [Token(Token = "0x6003066")]
    [Address(RVA = "0xFD9F70", Offset = "0xFD8D70", VA = "0x10FD9F70")]
    public bool Deserialize(JSON_Map src) => new bool();

    [Token(Token = "0x6003067")]
    [Address(RVA = "0xFDBA10", Offset = "0xFDA810", VA = "0x10FDBA10")]
    public void Release()
    {
    }

    [Token(Token = "0x6003068")]
    [Address(RVA = "0xFD9DD0", Offset = "0xFD8BD0", VA = "0x10FD9DD0")]
    public bool CheckEnableMove(Unit self, Grid grid, bool bSurinuke, bool ignoreObject = false)
    {
      return new bool();
    }

    [Token(Token = "0x6003069")]
    [Address(RVA = "0xFD9C90", Offset = "0xFD8A90", VA = "0x10FD9C90")]
    public bool CheckEnableMoveTeleport(Unit self, Grid grid, SkillData skill) => new bool();

    [Token(Token = "0x600306A")]
    [Address(RVA = "0xFD9B60", Offset = "0xFD8960", VA = "0x10FD9B60")]
    public bool CheckEnableMoveHeight(Unit self, Grid current, Grid next) => new bool();

    [Token(Token = "0x600306B")]
    [Address(RVA = "0xFDBC90", Offset = "0xFDAA90", VA = "0x10FDBC90")]
    public void ResetMoveRoutes()
    {
    }

    [Token(Token = "0x600306C")]
    [Address(RVA = "0xFDA2A0", Offset = "0xFD90A0", VA = "0x10FDA2A0")]
    public Grid[] FindPath(
      Unit unit,
      int startX,
      int startY,
      int goalX,
      int goalY,
      int disableHeight,
      GridMap<int> walkableField)
    {
      return (Grid[]) null;
    }

    [Token(Token = "0x600306D")]
    [Address(RVA = "0xFDAB00", Offset = "0xFD9900", VA = "0x10FDAB00")]
    public Grid GetMoveRoutes(int step) => (Grid) null;

    [Token(Token = "0x600306E")]
    [Address(RVA = "0xFDAAC0", Offset = "0xFD98C0", VA = "0x10FDAAC0")]
    public int GetMoveRoutesCount() => new int();

    [Token(Token = "0x600306F")]
    [Address(RVA = "0xFDAA50", Offset = "0xFD9850", VA = "0x10FDAA50")]
    public Grid GetCurrentMoveRoutes() => (Grid) null;

    [Token(Token = "0x6003070")]
    [Address(RVA = "0xFDAB60", Offset = "0xFD9960", VA = "0x10FDAB60")]
    public Grid GetNextMoveRoutes() => (Grid) null;

    [Token(Token = "0x6003071")]
    [Address(RVA = "0xFDB9B0", Offset = "0xFDA7B0", VA = "0x10FDB9B0")]
    public bool IsLastMoveGrid(Grid last) => new bool();

    [Token(Token = "0x6003072")]
    [Address(RVA = "0xFDABD0", Offset = "0xFD99D0", VA = "0x10FDABD0")]
    public void IncrementMoveStep()
    {
    }

    [Token(Token = "0x6003073")]
    [Address(RVA = "0xFDBBF0", Offset = "0xFDA9F0", VA = "0x10FDBBF0")]
    private void ResetGridSteps()
    {
    }

    [Token(Token = "0x6003074")]
    [Address(RVA = "0xFD92F0", Offset = "0xFD80F0", VA = "0x10FD92F0")]
    public bool CalcMoveSteps(Unit unit, Grid target, bool ignoreObject = false) => new bool();

    [Token(Token = "0x6003075")]
    [Address(RVA = "0xFD9670", Offset = "0xFD8470", VA = "0x10FD9670")]
    private Grid CalcNextMoveRoutes(Unit self, Grid current, bool last) => (Grid) null;

    [Token(Token = "0x6003076")]
    [Address(RVA = "0xFD90B0", Offset = "0xFD7EB0", VA = "0x10FD90B0")]
    public bool CalcMoveRoutes(Unit self) => new bool();

    [Token(Token = "0x6003077")]
    [Address(RVA = "0xFDBDB0", Offset = "0xFDABB0", VA = "0x10FDBDB0")]
    public BattleMap()
    {
    }

    [Token(Token = "0x6003078")]
    [Address(RVA = "0xFDBD00", Offset = "0xFDAB00", VA = "0x10FDBD00")]
    static BattleMap()
    {
    }
  }
}
